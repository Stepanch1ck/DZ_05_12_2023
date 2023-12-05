using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab_13
{
    internal class Building
    {
        private int _uniqueNumber;
        private int _height;
        private int _floors;
        private int _apartments;
        private int _entrances;

        public Building()
        {
            _height = 100;
            _floors = 10;
            _apartments = 100;
            _entrances = 10;
            _uniqueNumber = getNextUniqueNumber();
        }

        public Building(int height, int floors, int apartments, int entrances)
        {
            _height = height;
            _floors = floors;
            _apartments = apartments;
            _entrances = entrances;
            _uniqueNumber = getNextUniqueNumber();
        }

        private static int _nextUniqueNumber = 1;

        public int UniqueNumber
        {
            get { return _uniqueNumber; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }

        public int Apartments
        {
            get { return _apartments; }
            set { _apartments = value; }
        }

        public int Entrances
        {
            get { return _entrances; }
            set { _entrances = value; }
        }

        public int ApartmentsOnFloor
        {
            get { return Apartments / Floors; }
        }

        public int ApartmentsInEntrance
        {
            get { return Apartments / Entrances; }
        }

        public int FloorHeight
        {
            get { return Height / Floors; }
        }

        private static int getNextUniqueNumber()
        {
            int uniqueNumber = _nextUniqueNumber;
            _nextUniqueNumber++;
            return uniqueNumber;
        }

        public override string ToString()
        {
            return $"Номер здания: {UniqueNumber}, высота: {Height}, этажность: {Floors}, количество квартир: {Apartments}, количество подъездов: {Entrances}";
        }
    }
}
