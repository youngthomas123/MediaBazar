using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using Moq;

namespace MediaBazaarUnitTests
{
	[TestClass]
	public class EmployeeTest
	{
		private EmployeeContainer _employeeContainer;
		private Mock<IEmployeeDataAccess> _employeeDataAccessMock;

		[TestInitialize]
		public void Setup()
		{
			_employeeDataAccessMock = new Mock<IEmployeeDataAccess>();
			_employeeContainer = new EmployeeContainer(_employeeDataAccessMock.Object);
		}

		[TestMethod]
		public void AddEmployee_ValidEmployee_CallsAddEmployeeInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();

			// Act
			_employeeContainer.AddEmployee(employee);

			// Assert
			_employeeDataAccessMock.Verify(db => db.AddEmployee(employee), Times.Once);
		}

		[TestMethod]
		public void AddEmployee_UniqueBsn_AddsEmployeeToListAndCallsAddEmployeeInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			_employeeDataAccessMock.Setup(db => db.AddEmployee(employee));

			// Act
			_employeeContainer.AddEmployee(employee);

			// Assert
			_employeeDataAccessMock.Verify(db => db.AddEmployee(employee), Times.Once);
		}

		[TestMethod]
		public void AddShift_ValidData_CallsAddEmpShiftInDataAccess()
		{
			// Arrange
			DateTime day = DateTime.Now;
			int bsn = 123;
			MyEnums.ShiftTypes shiftType = MyEnums.ShiftTypes.MORNING;

			Employee employee = new Employee { BSN = bsn, ShiftsDates = new List<Shift>() }; // Initialize ShiftsDates
			_employeeDataAccessMock.Setup(db => db.AddEmpShift(It.IsAny<Employee>()));

			_employeeDataAccessMock
				.Setup(db => db.LoadEmployees())
				.Returns(new List<Employee> { employee }); // Return the employee from the mock data access

			// Act
			_employeeContainer.AddShift(day, bsn, shiftType);

			// Assert
			_employeeDataAccessMock.Verify(db => db.AddEmpShift(It.IsAny<Employee>()), Times.Once);
		}


		[TestMethod]
		public void RemoveEmpShift_ValidData_CallsRemoveEmpShiftInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			DateTime date = DateTime.Now;

			// Act
			_employeeContainer.RemoveEmpShift(employee, date);

			// Assert
			_employeeDataAccessMock.Verify(db => db.RemoveEmpShift(employee, date), Times.Once);
		}

		[TestMethod]
		public void DeleateEmployee_ValidBsn_CallsDeleateEmployeeInDataAccess()
		{
			// Arrange
			int bsn = 123;

			// Act
			_employeeContainer.DeleateEmployee(bsn);

			// Assert
			_employeeDataAccessMock.Verify(db => db.DeleateEmployee(bsn), Times.Once);
		}

		[TestMethod]
		public void GetEmployeeByBcn_ExistingBsn_ReturnsEmployee()
		{
			// Arrange
			int bsn = 123;
			Employee expectedEmployee = new Employee { BSN = bsn };
			_employeeDataAccessMock.Setup(db => db.LoadEmployees()).Returns(new List<Employee> { expectedEmployee });

			// Act
			Employee result = _employeeContainer.GetEmployeeByBcn(bsn);

			// Assert
			Assert.AreEqual(expectedEmployee, result);
		}

		[TestMethod]
		public void GetEmployeeByBcn_NonExistingBsn_ThrowsException()
		{
			// Arrange
			int bsn = 123;
			_employeeDataAccessMock.Setup(db => db.LoadEmployees()).Returns(new List<Employee>());

			// Act & Assert
			Assert.ThrowsException<Exception>(() => _employeeContainer.GetEmployeeByBcn(bsn));
		}

		[TestMethod]
		public void GetEmployeesByJobPosition_ExistingJob_ReturnsEmployeesWithMatchingJobPosition()
		{
			// Arrange
			MyEnums.JobPositions jobPosition = MyEnums.JobPositions.STORE_MANAGER;
			List<Employee> allEmployees = new List<Employee>
			{
				new Employee { Jobposition = MyEnums.JobPositions.STORE_MANAGER },
				new Employee { Jobposition = MyEnums.JobPositions.WAREHOUSE_MANAGER },
				new Employee { Jobposition = MyEnums.JobPositions.STORE_EMPLOYEE }
			};
			_employeeDataAccessMock.Setup(db => db.LoadEmployees()).Returns(allEmployees);

			// Act
			List<Employee> result = _employeeContainer.GetEmployeesByJobPosition(jobPosition);

			// Assert
			Assert.IsTrue(result.All(employee => employee.Jobposition == jobPosition));
		}

		[TestMethod]
		public void GetEmployeesByJobPosition_NonExistingJob_ReturnsEmptyList()
		{
			// Arrange
			MyEnums.JobPositions jobPosition = MyEnums.JobPositions.STORE_MANAGER;
			List<Employee> allEmployees = new List<Employee>
			{
				new Employee { Jobposition = MyEnums.JobPositions.STORE_EMPLOYEE },
				new Employee { Jobposition = MyEnums.JobPositions.WAREHOUSE_EMPLOYEE },
				new Employee { Jobposition = MyEnums.JobPositions.CASHIER }
			};
			_employeeDataAccessMock.Setup(db => db.LoadEmployees()).Returns(allEmployees);

			// Act
			List<Employee> result = _employeeContainer.GetEmployeesByJobPosition(jobPosition);

			// Assert
			Assert.AreEqual(0, result.Count);
		}

		[TestMethod]
		public void GetEmployees_ReturnsListOfEmployees()
		{
			// Arrange
			List<Employee> expectedEmployees = new List<Employee>
			{
				new Employee(),
				new Employee(),
				new Employee()
			};
			_employeeDataAccessMock.Setup(db => db.LoadEmployees()).Returns(expectedEmployees);

			// Act
			List<Employee> result = _employeeContainer.GetEmployees();

			// Assert
			CollectionAssert.AreEqual(expectedEmployees, result);
		}

		[TestMethod]
		public void UpdateEmpShift_ValidData_CallsUpdateEmpShiftInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();

			// Act
			_employeeContainer.UpdateEmpShift(employee);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmpShift(employee), Times.Once);
		}

		[TestMethod]
		public void AlreadyExists_NonExistingBsn_ReturnsFalse()
		{
			// Arrange
			int bsn = 123;
			Employee existingEmployee = new Employee { BSN = 456 };
			_employeeContainer.AddEmployee(existingEmployee); // Add an existing employee

			// Act
			bool result = _employeeContainer.AlreadyExists(bsn);

			// Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void UpdateEmpSickLeave_ValidData_CallsUpdateEmpSickLeaveInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			SickLeave sickLeave = new SickLeave();

			// Act
			_employeeContainer.UpdateEmpSickLeave(employee, sickLeave);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmpSickLeave(employee, sickLeave), Times.Once);
		}

		[TestMethod]
		public void UpdateEmpSickLeaveApproval_ValidData_CallsUpdateEmpSickLeaveApprovalInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			SickLeave sickLeave = new SickLeave();

			// Act
			_employeeContainer.UpdateEmpSickLeaveApproval(employee, sickLeave);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmpSickLeaveApproval(employee, sickLeave), Times.Once);
		}

		[TestMethod]
		public void AddShiftPreference_ValidData_CallsAddShiftPreferenceInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			ShiftPreference preference = new ShiftPreference();

			// Act
			_employeeContainer.AddShiftPreference(employee, preference);

			// Assert
			_employeeDataAccessMock.Verify(db => db.AddShiftPreference(employee, preference), Times.Once);
		}

		[TestMethod]
		public void UpdateEmployeeFirstName_ValidData_CallsUpdateEmployeeFirstNameInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			string newFirstName = "John";

			// Act
			_employeeContainer.UpdateEmployeeFirstName(employee, newFirstName);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmployeeFirstName(employee, newFirstName), Times.Once);
		}

		[TestMethod]
		public void UpdateEmployeeLastName_ValidData_CallsUpdateEmployeeLastNameInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			string newLastName = "Doe";

			// Act
			_employeeContainer.UpdateEmployeeLastName(employee, newLastName);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmployeeLastName(employee, newLastName), Times.Once);
		}

		[TestMethod]
		public void UpdateEmployeeTelNumber_ValidData_CallsUpdateEmployeeTelNumberInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			string newTelNumber = "1234567890";

			// Act
			_employeeContainer.UpdateEmployeeTelNumber(employee, newTelNumber);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmployeeTelNumber(employee, newTelNumber), Times.Once);
		}

		[TestMethod]
		public void UpdateEmployeeAddress_ValidData_CallsUpdateEmployeeAddressInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			string newAddress = "123 Main St";

			// Act
			_employeeContainer.UpdateEmployeeAddress(employee, newAddress);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmployeeAddress(employee, newAddress), Times.Once);
		}

		[TestMethod]
		public void UpdateEmployeeShiftDates_ValidData_CallsUpdateEmployeeShiftDatesInDataAccess()
		{
			// Arrange
			Employee employee = new Employee();
			List<DateTime> newShiftDates = new List<DateTime> { DateTime.Now, DateTime.Now.AddDays(1) };

			// Act
			_employeeContainer.UpdateEmpShift(employee);

			// Assert
			_employeeDataAccessMock.Verify(db => db.UpdateEmpShift(employee), Times.Once);
		}
	}
}