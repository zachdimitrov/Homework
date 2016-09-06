namespace HomeworkTasks
{
    using System;

    class Task_2_IfStatement
    {
        private bool shouldNotVisitCell;

        public bool ShouldNotVisitCell
        {
            get { return shouldNotVisitCell; }
            set { shouldNotVisitCell = value; }
        }

        public int MinX { get; set; }
        public int MaxX { get; set; }
        public int MinY { get; set; }
        public int MaxY { get; set; }

        public void DoSomethingComplex(int x, int y)
        {
            // this is the actual homework task

            bool isYinRange = MinY <= y && y <= MaxY;
            bool isXinRange = MinX <= x && x <= MaxX;

            if (ShouldNotVisitCell)
            {
                throw new ArgumentException("Should Not Visit Cell!");
            }
            else
            {
                if (isYinRange)
                {
                    if (isXinRange)
                    {
                        VisitCell();
                    }
                }
            }
            // end
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
