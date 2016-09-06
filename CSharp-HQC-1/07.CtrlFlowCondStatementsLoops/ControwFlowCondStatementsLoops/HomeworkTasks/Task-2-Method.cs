namespace HomeworkTasks
{
    using Models;

    public class PrepareFood
    {
        public Potato potato = new Potato();
        //... 
        public void CookVegetables(Vegetable potato)
        {
            if (potato != null)
            {
                if (potato.Peeled && !potato.Rotten)
                {
                    var chef = new Chef();
                    chef.Cook(potato);
                }
            }
        }
    }
}