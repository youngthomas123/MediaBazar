using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Classes;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarUnitTests
{
	[TestClass]
	public class ItemContainerTests
	{
		private Mock<IItemDataAccess> _itemDataAccessMock;
		private ItemContainer _itemContainer;

		[TestInitialize]
		public void Initialize()
		{
			_itemDataAccessMock = new Mock<IItemDataAccess>();
			_itemContainer = new ItemContainer(_itemDataAccessMock.Object);
		}

		[TestMethod]
		public void AddItem_ValidItem_CallsAddItemInDataAccess()
		{
			// Arrange
			Item item = new Item(Guid.NewGuid(), "testItem", "test description", 100000, 1000, 4, 1400);

			// Act
			_itemContainer.AddItem(item);

			// Assert
			_itemDataAccessMock.Verify(db => db.AddItem(item), Times.Once);
		}

		[TestMethod]
		public void DeleteItem_ValidItem_CallsDeleteItemInDataAccess()
		{
			// Arrange
			Item item = new Item(Guid.NewGuid(), "testItem", "test description", 100000, 1000, 4, 1400);

			// Act
			_itemContainer.DeleteItem(item);

			// Assert
			_itemDataAccessMock.Verify(db => db.DeleteItem(item), Times.Once);
		}

		[TestMethod]
		public void GetItemById_ExistingId_ReturnsItem()
		{
			// Arrange
			Guid itemId = Guid.NewGuid();
			string name = "Test Item";
			string description = "Test Description";
			int category = 1;
			int warehouseQuantity = 10000;
			int shopQuantity = 1000;
			decimal price = 2.99m;

			// Mock the data access layer
			_itemDataAccessMock.Setup(db => db.GetItemById(itemId)).Returns(new Item(itemId, name, description, warehouseQuantity, shopQuantity, category, price));

			// Act
			Item result = _itemContainer.GetItemById(itemId);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(itemId, result.Id);
			Assert.AreEqual(name, result.Name);
			Assert.AreEqual(description, result.Description);
			Assert.AreEqual(category, result.Category);
			Assert.AreEqual(warehouseQuantity, result.WarehouseQuantity);
			Assert.AreEqual(shopQuantity, result.ShopQuantity);
			Assert.AreEqual(price, result.Price);
		}



		[TestMethod]
		public void GetItem_ItemNotFound_ThrowsException()
		{
			// Arrange
			string name = "Test Item";
			string description = "Test Description";
			List<Item> items = new List<Item>();
			_itemDataAccessMock.Setup(db => db.LoadItem()).Returns(items);

			// Act and Assert
			Assert.ThrowsException<Exception>(() => _itemContainer.GetItem(name, description));
		}

		// Add more unit tests for the remaining methods in the ItemContainer class
	}
}
