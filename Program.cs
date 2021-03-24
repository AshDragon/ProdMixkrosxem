using System;

namespace ProdMixkrosxem
{
    class Program
    {
        static (string userLogin, string userPassword) InputLoginAndPassword()
        {
            Console.Write("Введите логин  : ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль : ");
            string password = Console.ReadLine();

            return (login, password);
        }
        /// <summary>
        /// Авторизует пользователя в системе. Принемает от пользователя логин и пароль.
        /// </summary>
        /// <returns>true - успешная авторизация. false - неуспешная авторизация.</returns>  

        static bool AuthorizeUser()
        {
            bool userAuthorized = false;

            string[] loginList = { "Админ", "Иванова", "Петровна", "Сергеева", "Васильева", "Семёнова" };
            string[] passwordList = { "000", "111", "222", "333", "444", "555" };

            int authorizationAttempCounter = 0;
            const int ALLOWARLBE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
            bool authirizationAttempAvailable = authorizationAttempCounter < ALLOWARLBE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

            while (authirizationAttempAvailable)
            {
                (string lgn, string psw) input = InputLoginAndPassword();
                string login = input.Item1, password = input.Item2;
                           
                // authorized = TryAuthorizeUser(login, password);
                {

                   for( int index = 0; index < loginList.Length && index < passwordList.Length; index++)
                        {
                            bool loginMatched, passwordMatched; // = MatchLoginAndPassword()
                            {
                                string loginByCurrentIndex = loginList[index];
                                loginMatched = loginByCurrentIndex == login;
                                string passwordByCurrentIndex = passwordList[index];
                                passwordMatched = passwordByCurrentIndex == password;
                            }

                            if (loginMatched && passwordMatched)
                            {
                                userAuthorized = true;
                                break;
                            }
                        }
                    }

                    if (userAuthorized)
                    {
                        Console.WriteLine("Вы успешно авторизованны. ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Логин или пароль введены не правильно. ");
                        authirizationAttempAvailable = ++authorizationAttempCounter < ALLOWARLBE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                        if (authirizationAttempAvailable)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Вы исчерпали количество попыток авторизациию Обратитесь к администратору. ");
                            break;
                        }
                    }
                }


                return userAuthorized;
            
        }

        /// <summary>
        /// Выводит инфомацию пользователю о совершенной покупке
        /// </summary>
        /// <param name="chipsPriceWithRate">Цена с коэфициэнтом</param>
        /// <param name="chipCost">Общая стоимость микросхем</param>
        /// <param name="discount">Скидка</param>
        /// <param name="paymentAmount">Сумма к оплате</param>
        static void RunQutputUserInterface(decimal chipsPriceWithRate,
                                           decimal chipCost,
                                           decimal discount,
                                           decimal paymentAmount)
        {
            Console.WriteLine($"Цена с коэфициэнтом      : {chipsPriceWithRate} руб.");
            Console.WriteLine($"Общая стоимость микросхем: {chipCost} руб.");
            Console.WriteLine($"Скидка                   : {discount} руб.");
            Console.WriteLine($"Сумма к оплате           : {paymentAmount} руб.");

            
        }
        static void Main(string[] args)
        {
            bool userAuthorized = AuthorizeUser();
            
            // Run (userAuthorized);
            {
                while (userAuthorized)
                {
                    string countryCode;
                    decimal ChipsQuontiti, ChipsPrice;
                    // countryCode, ChipsQuontiti, ChipsPrice = RunInputUserInterface ()
                    {
                       
                        Console.WriteLine("Нажмите Enter, для начала обслуживания нового клиента. ");
                        Console.ReadKey();

                        const string COUNTRY_CODES =
                             "======================================================\n" +
                             "Азербайджан (994) | Киргизия (996) | Таджикистан (992)\n" +
                             "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
                             "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
                             "Грузия      (995) | Молдова  (373) | Украина     (380)\n" +
                             "Казахстан   (007K) | Россия   (007) | Эстония     (372)\n" +
                             "------------------------------------------------------";
                        Console.WriteLine(COUNTRY_CODES);

                        // countryCode = ProcessCountryCode (CountryCode)
                        {
                            bool countryCodeIsCorrect;

                            do
                            {
                                Console.Write("Телефонный код страны    : ");
                                countryCode = Console.ReadLine();

                                // countryCode = DetectKazakhstanCode (countryCode)
                                {
                                    const string KAZAKHSTAN_CODE = "007";
                                    const string UPPERCASE_ENGLISH_LETTER_K = "K", LOWERCASE_ENGLISH_LETTER_k = "k",
                                    UPPERCASE_RUSSIAN_LETTER_К = "К", LOWERCASE_RUSSIAN_LETTER_к = "к";
                                    bool countryCodeIsKazakhstanCodeAndAnyLetteK =
                                        countryCode == (KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K) ||
                                        countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_k) ||
                                        countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_К) ||
                                        countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_к);
                                    if (countryCodeIsKazakhstanCodeAndAnyLetteK)
                                    {
                                        countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                                    }
                                }

                                // countryCodeIsCorrect = CheckCountryCode (countruCode)
                                {
                                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                    const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                                 GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                                                 LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                                 RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                                 UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                                    switch (countryCode)
                                    {
                                        case AZERBAIJAN_CODE:
                                        case ARMENIA_CODE:
                                        case BELARUS_CODE:
                                        case GEORGIA_CODE:
                                        case KAZAKHSTAN_CODE:
                                        case KYRGYZSTAN_CODE:
                                        case LATVIA_CODE:
                                        case LITHUANIA_CODE:
                                        case MOLDOVA_CODE:
                                        case RUSSIA_CODE:
                                        case TAJIKISTAN_CODE:
                                        case TURKMENISTAN_CODE:
                                        case UZBEKISTAN_CODE:
                                        case UKRAINE_CODE:
                                        case ESTONIA_CODE:
                                            {
                                                countryCodeIsCorrect = true;
                                                break;
                                            }
                                        default:
                                            {
                                                countryCodeIsCorrect = false;
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"Вы ввели несуществующий код: {countryCode}!");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                    }

                                }
                            }
                            while (countryCodeIsCorrect == false);

                        }

                        Console.Write("Количество микросхем     : ");
                        string stringQuontiti = Console.ReadLine();
                        ChipsQuontiti = Convert.ToDecimal(stringQuontiti);


                        Console.Write("Цена за одну микросхему  : ");
                        string stringPrice = Console.ReadLine();
                        ChipsPrice = Convert.ToDecimal(stringPrice);
                    }

                    decimal rate;

                    // rate = CalculatePriceRate (countryCode)
                    {
                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                        const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                     GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                                     LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                     RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                     UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                        switch (countryCode)
                        {
                            case AZERBAIJAN_CODE:
                                {
                                    const decimal AZERBAIJAN_RATE = 1.07m;
                                    rate = AZERBAIJAN_RATE;
                                    break;
                                }
                            case ARMENIA_CODE:
                                {
                                    const decimal ARMENIA_RATE = .95m;
                                    rate = ARMENIA_RATE;
                                    break;
                                }
                            case BELARUS_CODE:
                                {
                                    const decimal BELARUS_RATE = 1m;
                                    rate = BELARUS_RATE;
                                    break;
                                }
                            case GEORGIA_CODE:
                                {
                                    const decimal GEORGIA_RATE = 0.94m;
                                    rate = GEORGIA_RATE;
                                    break;
                                }
                            case KAZAKHSTAN_CODE:
                                {
                                    const decimal KAZAKHSTAN_RATE = .79m;
                                    rate = KAZAKHSTAN_RATE;
                                    break;
                                }
                            case KYRGYZSTAN_CODE:
                                {
                                    const decimal KYRGYZSTAN_RATE = .83m;
                                    rate = KYRGYZSTAN_RATE;
                                    break;
                                }
                            case TAJIKISTAN_CODE:
                                {
                                    const decimal TAJIKISTAN_RATE = .76m;
                                    rate = TAJIKISTAN_RATE;
                                    break;
                                }
                            case MOLDOVA_CODE:
                                {
                                    const decimal MOLDOVA_RATE = .97m;
                                    rate = MOLDOVA_RATE;
                                    break;
                                }
                            case RUSSIA_CODE:
                                {
                                    const decimal RUSSIA_RATE = 1m;
                                    rate = RUSSIA_RATE;
                                    break;
                                }
                            case TURKMENISTAN_CODE:
                                {
                                    const decimal TURKMENISTAN_RATE = .81m;
                                    rate = TURKMENISTAN_RATE;
                                    break;
                                }
                            case UZBEKISTAN_CODE:
                                {
                                    const decimal UZBEKISTAN_RATE = .98m;
                                    rate = UZBEKISTAN_RATE;
                                    break;
                                }
                            case UKRAINE_CODE:
                                {
                                    const decimal UKRAINE_RATE = 1m;
                                    rate = UKRAINE_RATE;
                                    break;
                                }
                            case LATVIA_CODE:
                                {
                                    const decimal LATVIA_RATE = 1.12m;
                                    rate = LATVIA_RATE;
                                    break;
                                }
                            case LITHUANIA_CODE:
                                {
                                    const decimal LITHUANIA_RATE = 1.12m;
                                    rate = LITHUANIA_RATE;
                                    break;
                                }
                            case ESTONIA_CODE:
                                {
                                    const decimal ESTONIA_RATE = 1.12m;
                                    rate = ESTONIA_RATE;
                                    break;
                                }
                            default:
                                {
                                    rate = 0;
                                    break;
                                }
                        }
                    }

                    decimal chipsPriceWithRate = ChipsPrice * rate;
                    decimal chipCost = ChipsQuontiti * chipsPriceWithRate;

                    decimal discount; //руб.
                    {
                        decimal discountPersentage; // %
                        {
                            bool discount20PctAvailable, discount50PctAvailable;
                            {
                                const decimal MIN_CHIPS_QUANTITY_FOR_DISCOUNT_20_PCT = 500,
                                              MIN_CHIPS_QUANTITY_FOR_DISCOUNT_50_PCT = 1000;

                                discount20PctAvailable = ChipsQuontiti >= MIN_CHIPS_QUANTITY_FOR_DISCOUNT_20_PCT &&
                                                         ChipsQuontiti < MIN_CHIPS_QUANTITY_FOR_DISCOUNT_50_PCT;

                                discount50PctAvailable = ChipsQuontiti >= MIN_CHIPS_QUANTITY_FOR_DISCOUNT_50_PCT;
                            }
                            if (discount20PctAvailable)
                            {
                                discountPersentage = 20; //%
                            }
                            else if (discount50PctAvailable)
                            {
                                discountPersentage = 50; //%
                            }
                            else
                            {
                                discountPersentage = 0; //%
                            }

                        }
                        discount = chipCost / 100 * discountPersentage;
                    }

                    decimal paymentAmount = chipCost - discount;

                    RunQutputUserInterface(chipsPriceWithRate, chipCost, discount, paymentAmount);

                }
            }
        }
    }
}
