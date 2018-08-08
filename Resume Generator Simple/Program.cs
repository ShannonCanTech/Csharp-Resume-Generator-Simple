using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_Generator_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, phoneNum, employer, emailAddress, jobTitle, employerCity, employerState, institution, degree, major;

            //Resume intro
            Console.WriteLine("*****Resume Generator*****");
            Console.WriteLine("Welcome to the resume generator!");
            Console.WriteLine("Enter your first name to get started: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Welcome, {0} {1}", firstName, lastName);

            Console.WriteLine("Enter phone number: ");
            phoneNum = Console.ReadLine();
            Console.WriteLine("Enter email address: ");
            emailAddress = Console.ReadLine();

            //Work History
            Console.WriteLine("*****Use this section to input your work history*****");
            Console.WriteLine("Enter your most recent job title: ");
            jobTitle = Console.ReadLine();
            Console.WriteLine("Employer name: ");
            employer = Console.ReadLine();
            Console.Write("Employer city: ");
            employerCity = Console.ReadLine();
            Console.Write("Employer state: ");
            employerState = Console.ReadLine();

            //Education History
            Console.WriteLine("*****Use this section to input your educational history*****");
            Console.WriteLine("Degree type: ");
            degree = Console.ReadLine();
            Console.WriteLine("Major: ");
            major = Console.ReadLine();
            Console.WriteLine("Name of instition: ");
            institution = Console.ReadLine();

            //Final Resume
            Console.WriteLine('\n' + "******************************** \n My Resume \n********************************" + '\n' + "{0} {1} | {2} | {3} " + '\n' +
                                "******************************** \n Professional Experience\n********************************" + '\n' +
                                "{4} at {5}" + '\n' +
                                "{6}, {7}" + '\n' +
                                "******************************** \n Educational Background \n********************************" + '\n' +
                                "{8}" + '\n' +
                                "{9}" + '\n' +
                                "{10}", firstName, lastName, emailAddress, phoneNum, jobTitle, employer, employerCity, employerState, degree, institution, major);
            Console.ReadKey();
        }
    }
}
