// <copyright file="Event.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EventsFormattingSingleFile
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    /// <summary>
    /// event trigger
    /// </summary>
    public class Event : IComparable
    {
        /// <summary>
        /// date of event
        /// </summary>
        private DateTime date;

        /// <summary>
        /// title of event
        /// </summary>
        private string title;

        /// <summary>
        /// location of event
        /// </summary>
        private string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class
        /// </summary>
        /// <param name="date">input date of event</param>
        /// <param name="title">input title of event</param>
        /// <param name="location">input location</param>
        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        /// <summary>
        /// compares two objects
        /// </summary>
        /// <param name="obj">object inputs</param>
        /// <returns>result of comparison</returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int eventByDate = this.date.CompareTo(other.date);
            int eventByTitle = this.title.CompareTo(other.title);
            int eventByLocation = this.location.CompareTo(other.location);

            if (eventByDate == 0)
            {
                if (eventByTitle == 0)
                {
                    return eventByLocation;
                }
                else
                {
                    return eventByTitle;
                }
            }
            else
            {
                return eventByDate;
            }
        }

        /// <summary>
        /// overrides ToString method
        /// </summary>
        /// <returns>string text</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}