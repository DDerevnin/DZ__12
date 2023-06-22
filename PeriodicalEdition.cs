using System;
using System.Text;

namespace Homework12
{
    public class PeriodicalEdition
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Issue { get; set; }
        public string Publisher { get; set; } 
        public EditionType Type { get; set; }
        public readonly int ISSN;
        public int Price;

        public PeriodicalEdition(string name, int year, int issue)
        {
            Name = name;
            Year = year;
            Issue = issue;
        }

        public string GetEditionTypeName()
        {
            switch (Type)
            {
                case EditionType.Almanac:
                    return "Альманах";
                case EditionType.Catalogue:
                    return "Каталог";
                case EditionType.Magazine:
                    return "Журнал";
                case EditionType.Newspaper:
                    return "Газета";
            }
            return "Другое";
        }

        public string GetInfo()
        {
            var result = new StringBuilder();
            result.Append($"Название: {Name}. Год: {Year}. Выпуск: {Issue}. Цена: {Price}. " +
                          $"Тип: {GetEditionTypeName()}.");
            if (Publisher != default)
                result.Append($" Издатель: {Publisher}.");
            if (ISSN != 0)
                result.Append($" ISSN: {ISSN}.");
            return result.ToString();
        }
    }
}
