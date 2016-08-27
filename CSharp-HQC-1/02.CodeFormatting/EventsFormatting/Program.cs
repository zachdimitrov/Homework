// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EventsFormattingSingleFile
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    /// <summary>
    /// main class of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// outputs text
        /// </summary>
        private static StringBuilder output = new StringBuilder();

        /// <summary>
        /// store events
        /// </summary>
        private static EventHolder events = new EventHolder();

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args">arguments of main method</param>
        public static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// executes a text command
        /// </summary>
        /// <returns>boolean value</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// lists events
        /// </summary>
        /// <param name="command">a string text command</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            events.ListEvents(date, count);
        }

        /// <summary>
        /// deletes events
        /// </summary>
        /// <param name="command">a string text command</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);

            events.DeleteEvents(title);
        }

        /// <summary>
        /// adds events
        /// </summary>
        /// <param name="command">a string text command</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// gets input parameters
        /// </summary>
        /// <param name="commandForExecution">command for execution</param>
        /// <param name="commandType">type of command</param>
        /// <param name="dateAndTime">date and time</param>
        /// <param name="eventTitle">title of event</param>
        /// <param name="eventLocation">location of event</param>
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// gets date
        /// </summary>
        /// <param name="command">command to execute</param>
        /// <param name="commandType">type of command</param>
        /// <returns>date and time</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }

        /// <summary>
        /// class for system messages
        /// </summary>
        public static class Messages
        {
            /// <summary>
            /// prints message
            /// </summary>
            public static void EventAdded()
            {
                output.Append("Event added\n");
            }

            /// <summary>
            /// prints message
            /// </summary>
            /// <param name="x">integer number</param>
            public static void EventDeleted(int x)
            {
                if (x == 0)
                {
                    NoEventsFound();
                }
                else
                {
                    output.AppendFormat("{0} events deleted\n", x);
                }
            }

            /// <summary>
            /// prints message
            /// </summary>
            public static void NoEventsFound()
            {
                output.Append("No events found\n");
            }

            /// <summary>
            /// prints event
            /// </summary>
            /// <param name="eventToPrint">event object</param>
            public static void PrintEvent(Event eventToPrint)
            {
                if (eventToPrint != null)
                {
                    output.Append(eventToPrint + "\n");
                }
            }
        }

        /// <summary>
        /// class for holding events
        /// </summary>
        public class EventHolder
        {
            /// <summary>
            /// too complex for me to understand
            /// </summary>
            private MultiDictionary<string, Event> eventByTitle = new MultiDictionary<string, Event>(true);

            /// <summary>
            /// ordered bag event
            /// </summary>
            private OrderedBag<Event> eventByDate = new OrderedBag<Event>();

            /// <summary>
            /// adds events
            /// </summary>
            /// <param name="date">date and time</param>
            /// <param name="title">title of event</param>
            /// <param name="location">location of event</param>
            public void AddEvent(DateTime date, string title, string location)
            {
                Event newEvent = new Event(date, title, location);
                this.eventByTitle.Add(title.ToLower(), newEvent);
                this.eventByDate.Add(newEvent);
                Messages.EventAdded();
            }

            /// <summary>
            /// deletes events
            /// </summary>
            /// <param name="titleToDelete">name of event to delete</param>
            public void DeleteEvents(string titleToDelete)
            {
                string title = titleToDelete.ToLower();
                int removed = 0;

                foreach (var eventToRemove in this.eventByTitle[title])
                {
                    removed++;
                    this.eventByDate.Remove(eventToRemove);
                }

                this.eventByTitle.Remove(title);
                Messages.EventDeleted(removed);
            }

            /// <summary>
            /// lists all events
            /// </summary>
            /// <param name="date">date and time of event</param>
            /// <param name="count">number of events</param>
            public void ListEvents(DateTime date, int count)
            {
                OrderedBag<Event>.View eventsToShow = this.eventByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
                int showed = 0;

                foreach (var eventToShow in eventsToShow)
                {
                    if (showed == count)
                    {
                        break;
                    }

                    Messages.PrintEvent(eventToShow);
                    showed++;
                }

                if (showed == 0)
                {
                    Messages.NoEventsFound();
                }
            }
        }
    }
}