﻿using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IEmployeeContainer
    {
        void AddEmployee(Employee employee);


        void DeleateEmployee(int BSN);


        List<Employee> LoadEmployees();


        void AddEmpShift(Employee emp);

        void UpdateEmpShift(Employee emp);
        void RemoveEmpShift(Employee emp, DateTime date);

        void UpdateEmpSickLeave(Employee emp, SickLeave sickLeave);

        void UpdateEmpSickLeaveApproval(Employee emp, SickLeave sickLeave);
        void UpdateEmployeSickLeaveManagerMessage(SickLeave sickLeave, Employee emp);
        void AddShiftPreference(Employee emp, ShiftPreference preference);
        void UpdateEmployeeFirstName(Employee emp, string newFirstName);
        void UpdateEmployeeLastName(Employee emp, string newLastName);
        void UpdateEmployeeTelNumber(Employee emp, string newTelNumber);
        void UpdateEmployeeAddress(Employee emp, string newAddress);
        public void UpdateQuotas(Dictionary<DayOfWeek, int> quotasToUpdate);
        public Dictionary<DayOfWeek, int> LoadQuotas();
        public void UpdateShiftPreference(int bsn, Dictionary<DayOfWeek, ShiftTypes> preferences);
        public void WriteShiftPreference(int bsn, Dictionary<DayOfWeek, ShiftTypes> preferences);

        // management 

        void AddEmployee(string firstName, string lastName, int bsn, string telNumber, string address,
                        ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
                        List<DayOfWeek> daysOff, int age, List<Shift> shiftDates, List<SickLeave> sickLeaves, List<ShiftPreference> shiftPreferences);


        Employee GetEmployeeByBcn(int bsn);
        List<Employee> GetEmployeesByJobPosition(JobPositions job);

        List<Employee> GetEmployees();

        bool AlreadyExists(int bsn);

        void AddShift(DateTime day, int bsn, ShiftTypes shiftType);
    }
}
