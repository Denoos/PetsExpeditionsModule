namespace ExpeditionsLogic.Models.LogicModels.BaseModels
{
    public class Entity
    {
        //Базовые парамеры\\
        public int AC { get; set; } //Класс брони
        public int BAB { get; set; } //Базовый бонус атаки
        public string BaseDamage { get; set; } //Базовая атака
        public string DamageBonus { get; set; } //Дополнительный урон
        public int CritHitMult { get; set; } //Множитель критического удара


        //Основные характериситики\\
        public int STR { get; set; } //сила
        public int DEX { get; set; } //Ловкость
        public int CON { get; set; } //Телосложение
        public int INT { get; set; } //Интелект
        public int WIS { get; set; } //Мудрость
        public int CHA { get; set; } //Харизма

        //Спасброски\\
        public int Fort { get; set; } //Телосложение
        public int Refl { get; set; } //РЕфлексов
        public int Will { get; set; } //Воли

        //Основная информация\\
        public int MaxHP { get; set; } //Максимальное здоровье
        public string Name { get; set; } //Имя питомца
    }
}
