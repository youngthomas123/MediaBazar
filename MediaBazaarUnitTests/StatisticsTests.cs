using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Dtos;
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
	public class StatisticsTests
	{
		private Mock<IStatisticsDataAccess> _statisticsDataAccessMock;
		private StatisticsContainer _statisticsContainer;

		[TestInitialize]
		public void Setup()
		{
			_statisticsDataAccessMock = new Mock<IStatisticsDataAccess>();
			_statisticsContainer = new StatisticsContainer(_statisticsDataAccessMock.Object);
		}

		[TestMethod]
		public void LoadDataIntoColumns_ValidData_CallsLoadDataIntoColumnsInDataAccess()
		{
			// Arrange
			string chartData = "Sample chart data";

			// Act
			_statisticsContainer.LoadDataIntoColumns(chartData);

			// Assert
			_statisticsDataAccessMock.Verify(db => db.LoadDataIntoColumns(chartData), Times.Once);
		}

		[TestMethod]
		public void ShowShiftAttendance_ValidData_ReturnsAttendance()
		{
			// Arrange
			double expectedAttendance = 85.5;
			_statisticsDataAccessMock.Setup(db => db.ShowShiftAttendance()).Returns(expectedAttendance);

			// Act
			double result = _statisticsContainer.ShowShiftAttendance();

			// Assert
			Assert.AreEqual(expectedAttendance, result);
		}

		[TestMethod]
		public void GetItemStatsDto_ValidCategory_ReturnsItemStatsDto()
		{
			// Arrange
			string category = "Test Category";
			int[] salesPerMonth = { 10, 20, 15, 12, 18, 25, 22, 30, 17, 14, 28, 10 };
			_statisticsDataAccessMock
				.Setup(db => db.NumberOfSales(It.IsAny<int>(), category))
				.Returns<int, string>((month, cat) => salesPerMonth[month - 1]);

			// Act
			ItemStatsDto result = _statisticsContainer.GetItemStatsDto(category);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(category, result.Category);
			Assert.AreEqual(salesPerMonth[0], result.Jan);
			Assert.AreEqual(salesPerMonth[1], result.Feb);
			Assert.AreEqual(salesPerMonth[2], result.Mar);
			Assert.AreEqual(salesPerMonth[3], result.Apr);
			Assert.AreEqual(salesPerMonth[4], result.May);
			Assert.AreEqual(salesPerMonth[5], result.Jun);
			Assert.AreEqual(salesPerMonth[6], result.Jul);
			Assert.AreEqual(salesPerMonth[7], result.Aug);
			Assert.AreEqual(salesPerMonth[8], result.Sep);
			Assert.AreEqual(salesPerMonth[9], result.Oct);
			Assert.AreEqual(salesPerMonth[10], result.Nov);
			Assert.AreEqual(salesPerMonth[11], result.Dec);
		}

	}
}
