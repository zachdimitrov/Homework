namespace HomeworkTasks
{
    using System;
    using Models;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public void Cook(Vegetable vegetable)
        {
            Bowl bowl = GetBowl();
            bowl.Add(vegetable);
        }

        private Bowl GetBowl()
        {
            var bowl = new Bowl();
            return bowl;
        }

        private Carrot GetCarrot()
        {
            var carrot = new Carrot();
            return carrot;
        }

        private Potato GetPotato()
        {
            var potato = new Potato();
            return potato;
        }

        private void Cut(Vegetable potato)
        {
            potato.Cut = true;
        }

        private void Cut(Potato potato)
        {
            potato.Cut = true;
        }

        private void Cut(Carrot carrot)
        {
            carrot.Cut = true;
        }

        private void Peel(Potato potato)
        {
            potato.Peeled = true;
        }

        private void Peel(Carrot carrot)
        {
            carrot.Peeled = true;
        }
    }
}