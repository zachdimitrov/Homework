using System;

namespace HomeworkTasks.Models
{
    public class Vegetable
    {
        public Vegetable()
        {
            // initial state of every vegetable is not peeled and not cut
            this.Peeled = false;
            this.Cut = false;
            this.Rotten = false;
        }

        private bool peeled;
        private bool cut;
        private bool rotten;

        public bool Rotten
        {
            get { return rotten; }
            set
            {
                if (value == false && this.rotten == true)
                {
                    throw new ArgumentException("Vegetables already rotten cannot be made fresh again!");
                }
                rotten = value;
            }
        }

        public bool Cut
        {
            get { return cut; }
            set
            {
                if (value == false && this.cut == true)
                {
                    throw new ArgumentException("Vegetables already cut cannot be made whole again!");
                }
                cut = value;
            }
        }

        public bool Peeled
        {
            get { return peeled; }
            set
            {
                if (value == false && this.peeled == true)
                {
                    throw new ArgumentException("Vegetables already peeled cannot be made unpeeled!");
                }
                peeled = value;
            }
        }
    }
}