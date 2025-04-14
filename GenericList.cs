namespace Less0_1
{
    //string newName = Console.ReadLine() ?? string.Empty;
    //string n = "PHUC";
    //changeName(ref n, newName);
    //Console.WriteLine($"name: {n}");
    //int width = ReadInt("width: ");
    //int height = ReadInt("height: ");
    //int area = CalcArea(width, height);
    //Console.WriteLine($"Area: {area}");

    //int[] numbers = { 1, 2, 3, 4, 5 };
    //if (SumOfNumbers(numbers, out int total))
    //{
    //    Console.WriteLine($"Sum of numbers: {total}");
    //}
    //else
    //{
    //    Console.WriteLine("No numbers to sum.");
    //}

    //string name = "HAI";
    //int age = 27;
    //int birthMonth = 12;
    //Console.WriteLine($"Name: {p.name} - age: {p.age} ---bith moth: {p.birthMonth}");

    //Dog dog = new Dog();
    //Icontrol control = dog;
    //Isurface surface = dog;

    //control.paint();
    //    surface.paint();

    /// <summary>
    /// Defines the <see cref="Person" />
    /// </summary>
    public struct Person
    {
        /// <summary>
        /// Defines the <see cref="Icontrol" />
        /// </summary>
        public interface Icontrol
        {
            /// <summary>
            /// The paint
            /// </summary>
            void paint();
        }

        /// <summary>
        /// The SumOfNumbers
        /// </summary>
        /// <param name="numbers">The numbers<see cref="int[]"/></param>
        /// <param name="total">The total<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        internal static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;
            if (numbers.Length > 0)
            {
                foreach (var item in numbers)
                {
                    total += item;
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// The ReadInt
        /// </summary>
        /// <param name="message">The message<see cref="String"/></param>
        /// <returns>The <see cref="int"/></returns>
        internal static int ReadInt(String message)
        {
            Console.Write($"Enter a {message}");
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// The ReturnName
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        internal static string ReturnName()
        {
            return "HAI Son";
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Defines the age
        /// </summary>
        private int age;

        /// <summary>
        /// Defines the birthMonth
        /// </summary>
        private int birthMonth;

        /// <summary>
        /// The setAge
        /// </summary>
        /// <param name="age">The age<see cref="int"/></param>
        public void setAge(int age) => this.age = age >= 0 && age <= 120 ? age : -1;

        /// <summary>
        /// The getAge
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int getAge() => age;

        /// <summary>
        /// The getName
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public string getName() => name;

        /// <summary>
        /// The setName
        /// </summary>
        /// <param name="name">The name<see cref="string"/></param>
        public void setName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Unknown";
    }
}
