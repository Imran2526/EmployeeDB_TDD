﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrol_DB;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeePayrollsTester
{
    [TestClass]
    public class EmployeeMultithreading
    {
        /// <summary>
        /// UC 1 Multithreding
        /// </summary>
        [TestMethod]
        public void AddRecord_AndClaulate_ExecutionTime()
        {
            List<EmployeeModel> modelList = new List<EmployeeModel>();
            modelList.Add(new EmployeeModel() { Id = 1, name = "Imran", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 2, name = "shaikh", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 4, name = "nijam", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 3, name = "sayaad", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 5, name = "amit", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 8, name = "tambe", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 7, name = "amol", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 9, name = "prajaapti", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 10, name = "wankhede", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 11, name = "suraj", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 12, name = "Dhiraj", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable =4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 14, name = "siraj", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'M', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable = 4500, netpay = 5600, income_tax = 546.00 });
            modelList.Add(new EmployeeModel() { Id = 15, name = "simran", basic_pay = 450000, start_Date = new DateTime(2020, 01, 04), gender = 'F', phoneNumber = "2345676655", department = "HR", address = "Pune", deduction = 4000, taxable = 4500, netpay = 5600, income_tax = 546.00 });

            EmployeePayrollOperation employeePayroll = new EmployeePayrollOperation();
            DateTime startTime = DateTime.Now;
            employeePayroll.AddEmployeeToPayroll(modelList);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTime - startTime));
            EmployeeRepo payrollRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel
            {
                Id = 158,
                name = "Abhilasha",
                basic_pay = 80000,
                start_Date = new DateTime(2020, 01, 04),
                gender = 'F',
                phoneNumber = "1045676655",
                department = "Finance",
                address = "Pune",
                deduction = 4500,
                taxable =8500,
                netpay = 5760,
                income_tax = 12000.00
            };
            DateTime startTimes = DateTime.Now;
            payrollRepo.AddRecord(employeeModel);
            DateTime endTimes = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTimes - startTimes));

            ///UC 2 with Thread
            DateTime startTimeWithThread = DateTime.Now;
            employeePayroll.AddEmployee_WithThread(modelList);
            DateTime endTimeWithThread = DateTime.Now;
            Console.WriteLine("Duration with thread = " + (startTimeWithThread - endTimeWithThread));
        }

        /// <summary>
        /// UC 5 Add Multiple Record
        /// </summary>
        [TestMethod]
        public void AddMultiple_Record()
        {
            EmployeeRepo payrollRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel
            {
                Id = 159,
                name = "Pratibha",
                basic_pay = 804000,
                start_Date = new DateTime(2020, 01, 04),
                gender = 'F',
                phoneNumber = "9995676655",
                department = "Finance",
                address = "Mumbai",
                deduction = 6500,
                taxable = 9500,
                netpay = 9760,
                income_tax = 12000.00
            };

            DateTime startTimes = DateTime.Now;
            payrollRepo.AddRecord(employeeModel);
            DateTime endTimes = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTimes - startTimes));
        }

        /// <summary>
        /// UC 6 Updtae Salary
        /// </summary>
        
        [TestMethod]
        public void GivenQuery_ShouldUpdateSalary()
        {
            EmployeeRepo payrollRepo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel()
            {
                name = "Imran",
                basic_pay =888888
            };
            DateTime startDataTimeforDB = DateTime.Now;
            payrollRepo.UpdateSalary(model);
            DateTime stopDateTimeforDB = DateTime.Now;
            Console.WriteLine("Duration for Updatation in DB : " + (stopDateTimeforDB - startDataTimeforDB));
        }
    }
}


