using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace oop.Model
{
    public class Hamster
    {
        private double number;
        private double time;
        private double consuption;
        public Hamster(double number, double time, double consuption)
        {
            this.number = number;
            this.time = time;
            this.consuption = consuption;
        }

        public double Number
        {
            get => number; set => number = value;
        }

        public double Time
        {
            get => time; set => time = value;
        }

        public double Consuption
        {
            get => consuption; set => consuption = value;
        }
        //Egy hörcsög egy óra kerekezéssel 28 watt energiát állít elő
        public double EnergyOneDay
        {
            get
            {
                double oneday = number*time*28;
                return oneday;
            }
        }

        public double EnergyOneMonth
        {
            get
            {
                double onemonth = EnergyOneDay * 30;
                return onemonth;
            }
        }

        public double EnergyPercent
        {
            get 
            {
                double energy = Math.Round(EnergyOneMonth/consuption*100);
                return energy;
            }
        }

        public double NumberOfHamsters
        {
            get
            {
                //egy hörcsögre jutó termelt energia egy hónapban a megadott kerekezési idővel
                double oneHamster = time*28*30;
                double hamsterNumber = consuption/oneHamster;
                return hamsterNumber;
            }
        }
    }
}