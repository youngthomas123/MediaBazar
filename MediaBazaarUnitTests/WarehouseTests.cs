using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarUnitTests
{
	[TestClass]
	public class WarehouseTests
	{
		private Mock<IWarehouseDataAccess> _warehouseDataAccessMock;
		private WarehouseContainer _warehouseContainer;

		[TestInitialize]
		public void Initialize()
		{
			_warehouseDataAccessMock = new Mock<IWarehouseDataAccess>();
			_warehouseContainer = new WarehouseContainer(_warehouseDataAccessMock.Object);
		}

		[TestMethod]
		public void AddWarehouse_CallsAddWarehouseInDataAccess()
		{
			// Arrange
			Warehouse warehouse = new Warehouse { Name = "Test Warehouse" };

			// Act
			_warehouseContainer.AddWarehouse(warehouse);

			// Assert
			_warehouseDataAccessMock.Verify(db => db.AddWarehouse(warehouse), Times.Once);
		}

		[TestMethod]
		public void AssignEmployeeToWarehouse_CallsAssignEmployeeToWarehouseInDataAccess()
		{
			// Arrange
			int bsn = 123;
			Guid warehouseId = Guid.NewGuid();

			// Act
			_warehouseContainer.AssignEmployeeToWarehouse(bsn, warehouseId);

			// Assert
			_warehouseDataAccessMock.Verify(db => db.AssignEmployeeToWarehouse(bsn, warehouseId), Times.Once);
		}

		[TestMethod]
		public void AssignItemToWarehouse_CallsAssignItemToWarehouseInDataAccess()
		{
			// Arrange
			Guid itemId = Guid.NewGuid();
			Guid warehouseId = Guid.NewGuid();

			// Act
			_warehouseContainer.AssignItemToWarehouse(itemId, warehouseId);

			// Assert
			_warehouseDataAccessMock.Verify(db => db.AssignItemToWarehouse(itemId, warehouseId), Times.Once);
		}

		[TestMethod]
		public void DeleteWarehouse_CallsDeleteWarehouseInDataAccess()
		{
			// Arrange
			string name = "Test Warehouse";

			// Act
			_warehouseContainer.DeleteWarehouse(name);

			// Assert
			_warehouseDataAccessMock.Verify(db => db.DeleteWarehouse(name), Times.Once);
		}

		[TestMethod]
		public void GetWarehouseByName_ReturnsWarehouseFromDataAccess()
		{
			// Arrange
			string name = "Test Warehouse";
			Warehouse expectedWarehouse = new Warehouse { Name = name };
			_warehouseDataAccessMock.Setup(db => db.GetWarehouseByName(name)).Returns(expectedWarehouse);

			// Act
			Warehouse result = _warehouseContainer.GetWarehouseByName(name);

			// Assert
			Assert.AreEqual(expectedWarehouse, result);
		}

		[TestMethod]
		public void LoadWarehouse_ReturnsListOfWarehousesFromDataAccess()
		{
			// Arrange
			List<Warehouse> expectedWarehouses = new List<Warehouse>
			{
				new Warehouse { Name = "Warehouse 1" },
				new Warehouse { Name = "Warehouse 2" }
			};
			_warehouseDataAccessMock.Setup(db => db.LoadWarehouse()).Returns(expectedWarehouses);

			// Act
			List<Warehouse> result = _warehouseContainer.LoadWarehouse();

			// Assert
			CollectionAssert.AreEqual(expectedWarehouses, result);
		}

		[TestMethod]
		public void LoadWarehouseEmployees_ReturnsListOfEmployeesFromDataAccess()
		{
			// Arrange
			Guid warehouseId = Guid.NewGuid();
			List<Employee> expectedEmployees = new List<Employee>
			{
				new Employee { BSN = 123 },
				new Employee { BSN = 456 }
			};
			_warehouseDataAccessMock.Setup(db => db.LoadWarehouseEmployees(warehouseId)).Returns(expectedEmployees);

			// Act
			List<Employee> result = _warehouseContainer.LoadWarehouseEmployees(warehouseId);

			// Assert
			CollectionAssert.AreEqual(expectedEmployees, result);
		}

		[TestMethod]
		public void LoadWarehouseItems_ReturnsListOfItemsFromDataAccess()
		{
			// Arrange
			Guid warehouseId = Guid.NewGuid();
			List<Item> expectedItems = new List<Item>
			{
				new Item { Id = Guid.NewGuid() },
				new Item { Id = Guid.NewGuid() }
			};
			_warehouseDataAccessMock.Setup(db => db.LoadWarehouseItems(warehouseId)).Returns(expectedItems);

			// Act
			List<Item> result = _warehouseContainer.LoadWarehouseItems(warehouseId);

			// Assert
			CollectionAssert.AreEqual(expectedItems, result);
		}
	}
}
