using System;

namespace TumakovLab_13
{
    internal class Buildings
    {
        private Building[] _buildings = new Building[10];

        public Buildings()
        {
            for (int i = 0; i < _buildings.Length; i++)
            {
                _buildings[i] = new Building();
            }
        }

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= _buildings.Length)
                {
                    throw new ArgumentOutOfRangeException("Индекс выходит за пределы диапазона");
                }

                return _buildings[index];
            }
        }
    }
}
