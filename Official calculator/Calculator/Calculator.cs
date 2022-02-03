namespace Official_calculator
{
    class Calculator<T>
    {
        public Calculator()
        {
            var example = default(T);
            var isInt = (example is int);
            var isFloat = (example is float);
            var isDouble = (example is double);

            if (isInt)
            {

            }
            else if (isFloat)
            {

            }
            else if (isDouble)
            {

            }
            else
            {
                System.Console.WriteLine("You have made a mistake. Start again.");
            }
        }

        public T Add(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber + secondNumber;
        }
        public T Subtract(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber - secondNumber;
        }
        public T Multiply(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber * secondNumber;
        }
        public T Divide(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber / secondNumber;
        }

    }
}
