using System.Text.RegularExpressions;

namespace Domain.Models.DataBaseModels
{
    public static class Dice
    {
        public static int Rolling(string dice)
        {
            if (InvalidnessCheck(dice))
                throw new ArgumentException("Ошибка в валидности переданого кубика!");

            var diceValues = dice.Split('d', StringSplitOptions.RemoveEmptyEntries);
            var times = int.Parse(diceValues[0]);
            var diceType = int.Parse(diceValues[1]);

            var rnd = new Random();
            var result = 0;

            for (int i = 0; i < times; i++)
                result += rnd.Next(++diceType);

            return result;
        }

        private static bool InvalidnessCheck(string dice)
        {
            var result = true;

            var regex = new Regex("^(?!\\d+$)(([1-9]\\d*)?[Dd]?[1-9]\\d*( ?[+-] ?)?)+$");
            if (regex.IsMatch(dice))
                result = false;

            var diceValue = int.Parse(dice.Split('d', StringSplitOptions.RemoveEmptyEntries)[1]);
            int[] validValues = [2, 4, 6, 8, 10, 12, 20];
            if (!validValues.Contains(diceValue))
                result = false;

            return result;
        }
    }
}
