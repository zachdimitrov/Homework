namespace SocietiesCore.Models.Humans
{
    using Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure.Enumerations.Human;
    using Infrastructure.Utilities;
    using Contracts;

    public class Waiter : Human, IWaiter
    {
        private decimal tip;
        private Dictionary<IHuman, IRestaurantOrder> orders;

        public Waiter(string name, int age, HairType hairColor, EyesColorType eyesColor, FaceType face, RaceType race, GenderType gender, ReligionType religion) : base(name, age, hairColor, eyesColor, face, race, gender, religion)
        {
            this.orders = new Dictionary<IHuman, IRestaurantOrder>();
        }

        public decimal Tip
        {
            get
            {
                return this.tip;
            }
            set
            {
                this.tip = value;
            }
        }

        public void GetOrder(IRestaurantOrder order, IHuman client)
        {
            this.orders.Add(client, order);
        }

        public void RequestPayment(IHuman client)
        {
            throw new NotImplementedException();
        }

        public void ServeOrder(IHuman client)
        {
            var clientOrder = this.orders[client];
            client.Eat(clientOrder.Foods);
        }
    }
}
