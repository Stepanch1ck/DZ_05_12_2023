using System;

namespace TumakovLab14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public DateTime DateDeveloped { get; set; }
        public string Organization { get; set; }

        public DeveloperInfoAttribute(string developerName, string dateDeveloped)
        {
            this.DeveloperName = developerName;
            if (DateTime.TryParse(dateDeveloped, out DateTime result))
            {

                this.DateDeveloped = result;
            }
            else
            {
                throw new ArgumentException("Неверный формат даты!", nameof(dateDeveloped));
            }
                
        }

    }
}
