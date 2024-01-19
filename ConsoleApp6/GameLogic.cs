// nocopy

namespace ConsoleApp6
{
    internal class GameLogic
    {
        /// <summary>
        /// правила игры 
        /// </summary>
        /// <returns></returns>
        public static string Help ()
        {
            return "\"камень\"  побеждает ножницы\n" +
                   "\"ножницы\" побеждает бумагу\n" +
                   "\"бумага\"  побеждает камень\n";
        }

        /// <summary>
        /// Определяет кто  победил  в  раунде 
        /// </summary>
        /// <param name="userOpt">вариант  игрока, например "камень"</param>
        /// <returns>Возвращает  строку с победителем  например "Компьютер выбрал "камень" - Компьютер  победил" </returns>
        /// <exception cref="Exception">ошибка если не верный формат варианта </exception>
        public static string IsWin (string   userOpt )
        {

            string us = userOpt.ToLower().Trim(); // переводим в  нижний регистр  и  убираем пробелы, например  " БуМага   "  будет  "бумага" 
            if (IsTryOptions(us) == false) // проверяем  вариант  *****************
            {
                throw new Exception("Не верный вариант");  // если такого  нет  то  ошибка 
            }
            
            string pc = GetOptions();  // получаем  вариант  от пк   *****************
            string mes = "Компьютер выбрал \"" + pc + "\""; // приготовим  сообщение, например "Компьютер выбрал "камень""

            if (us == pc) { return "ничья"; } 
              
            if (us == "камень" && pc == "ножницы") { return mes  + " -  Вы победили"; }  // будет "Компьютер выбрал "ножницы" -  Вы победили"

            if (us == "ножницы" && pc == "бумага")  { return mes + " -  Вы победили"; }   // будет "Компьютер выбрал "бумага" -  Вы победили"

            if (us == "бумага" && pc == "камень")    { return mes + " -  Вы победили"; }  // будет "Компьютер выбрал "камень" -  Вы победили"

            return mes + " - Компьютер  победил";
        }

        /// <summary>
        /// определяет  верно ли  пользователь ввел  вариант  
        /// </summary>
        /// <param name="userOpt">вариант  игрока, например "камень"</param>
        /// <returns>Да, если верно</returns>
        private static bool IsTryOptions(string userOpt)
        {
            if(userOpt == "камень" || userOpt == "ножницы" || userOpt == "бумага")
                return true;

            return false;
        }

        /// <summary>
        /// генерация  варианта  для пк
        /// </summary>
        /// <returns>Возвращает случайный вариант, например "ножницы"</returns>
        private static string GetOptions ()
        {
            Random rand = new Random();
            int x = rand.Next(0, 3); // случайное  число  от  0 до  3  //  0, 1 , 2,
            return GetOptionByCode(x);     // *****************
        }

        /// <summary>
        /// Выбор  варианта  по  коду 
        /// </summary>
        /// <param name="option"> число  от 0 до 3</param>
        /// <returns>если 0 - то камень </returns>
        /// <exception cref="Exception">если нет  такого варианта </exception>
        private static string GetOptionByCode(int option)
        {
            switch (option)
            {
                case 0 : return "камень"; break;
                case 1 : return "ножницы"; break;
                case 2: return "бумага"; break;
                default: throw new Exception("Eror");
            }
        }
    }
}
