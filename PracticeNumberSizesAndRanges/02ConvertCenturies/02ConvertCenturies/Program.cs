namespace _02ConvertCenturies
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please input centuries (): ");
            try
            {
                int centuries = Convert.ToInt32(Console.ReadLine());
                long years = centuries * 100L;  
                long days = checked(years * 365L + years / 4 - years / 100 + years / 400); 
                long hours = checked(days * 24L);
                long minutes = checked(hours * 60L);
                long seconds = checked(minutes * 60L);
                decimal milliseconds = checked((decimal)seconds * 1000L);
                decimal microseconds = checked(milliseconds * 1000L);
                decimal nanoseconds = checked(microseconds * 1000M);
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine($"{oe.Message}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{fe.Message}");
            }
        }
    }
}
