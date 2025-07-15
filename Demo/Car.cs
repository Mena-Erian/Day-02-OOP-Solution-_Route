using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Attribute
        private int id;
        private string? model;
        private double speed;

        #endregion


        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
        }

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {id} \nModel = {model} \nSpeed = {speed}";
        } 
        #endregion


    }
}
