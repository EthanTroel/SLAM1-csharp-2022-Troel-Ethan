using System;

namespace Triangle_TP
{

    class Program
    {
        static void Main(string[] args)
        {
            ManageFees m = new ManageFees();
            double dailyRate =
                m.readDouble("Enter your daily rate:");
            int noOfDays = m.readInt("Enter the number of days:");
            double fee =
                m.calculateFee(dailyRate, noOfDays);
            m.writeFee(fee);
            Console.ReadLine();

        }

        class ManageFees
        {
            public void writeFee(double p)
            {
                //write "The consultant's fee is : xxx
            }

            public double calculateFee(double dailyRate, int noOfDays)
            {
                throw new NotImplementedException();

            }


            public int readInt(string p)
            {
                throw new NotImplementedException();

            }

            public double readDouble(string p)
            {
                throw new NotImplementedException();
            }
        }

    }
}