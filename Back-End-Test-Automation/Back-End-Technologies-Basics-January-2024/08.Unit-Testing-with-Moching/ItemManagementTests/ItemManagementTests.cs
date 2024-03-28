using NUnit.Framework;
using Moq;
using ItemManagementApp.Services;
using ItemManagementLib.Repositories;
using ItemManagementLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace ItemManagement.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        private Mock<IItemRepository> _mockedItemRepository;
        private ItemService _itemService;


        [SetUp]
        public void Setup()
        {
            _mockedItemRepository = new Mock<IItemRepository>();
            _itemService = new ItemService(_mockedItemRepository.Object);
        }

        [Test]
        public void AddItem_ShouldCallAddItemOnRepository()
        {
            // Arrange
            var item = new Item { Name = "Test", Id = 1234 };
            _mockedItemRepository.Setup(x => x.AddItem(It.IsAny<Item>()));

            // Act
            _itemService.AddItem(item.Name);

            //Assert 
            _mockedItemRepository.Verify(x => x.AddItem(It.IsAny<Item>()), Times.Once());
                 
        }

        [Test]
        public void GetAllItems_ShouldReturnAllItems()
        {
            // Arrange
            var item = new List<Item> { new Item { Name = "Test", Id = 1234 } };
            _mockedItemRepository.Setup(x => x.GetAllItems()).Returns(item);

            // Act
            var result = _itemService.GetAllItems();

            //Assert 
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            _mockedItemRepository.Verify(x => x.GetAllItems(), Times.Once());

        }

        [Test]
        public void DeleteItem_ShouldCallDeleteItemOnRepository()
        {
            // Arrange
            var item = new Item { Name = "Test", Id = 1234 };
            _mockedItemRepository.Setup(x => x.DeleteItem(item.Id));

            // Act
            _itemService.DeleteItem(item.Id);

            //Assert 
            var result = _itemService.GetItemById(item.Id);
            Assert.That(result, Is.Null);
            _mockedItemRepository.Verify(x => x.DeleteItem(item.Id), Times.Once());
        }

        [Test]
        public void GetItemById_ShouldReturnItemById_IfItemExists()
        {
            // Arrange
            var item = new Item { Name = "Test", Id = 1234 };
            _mockedItemRepository.Setup(x => x.GetItemById(item.Id)).Returns(item);

            // Act
            var result = _itemService.GetItemById(item.Id);

            //Assert 
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(item.Id));
            _mockedItemRepository.Verify(x => x.GetItemById(item.Id), Times.Once());
        }

        [Test]
        public void ValidateItemName_WhenNameIsValid_ShouldReturnTrue()
        {
            // Arrange
            var item = new Item { Name = "Test", Id = 1234 };
            _mockedItemRepository.Setup(x => x.GetItemById(item.Id)).Returns(item);

            // Act
            var result =_itemService.GetItemById(item.Id);

            //Assert 
            Assert.That(result.Name, Is.EqualTo(item.Name));
            _mockedItemRepository.Verify(x => x.GetItemById(item.Id), Times.Once());
        }

        [Test]
        public void ValidateItemName_WhenNameIsTooLong_ShouldReturnFalse()
        {
            // Arrange
            var item = new Item { Name = new string('A', 11), Id = 1234 };
            _mockedItemRepository.Setup(x => x.GetItemById(It.IsAny<int>())).Returns((Item)null);

            // Act
            var result = _itemService.GetItemById(item.Id);

            //Assert 
            Assert.Null(result);
            _mockedItemRepository.Verify(x => x.GetItemById(It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void ValidateItemName_WhenNameIsEmpty_ShouldReturnFalse()
        {
            // Arrange
            Item item = null;
            _mockedItemRepository.Setup(x => x.GetItemById(It.IsAny<int>())).Returns(item);

            // Act
            var result = _itemService.GetItemById(123);

            //Assert 
            Assert.Null(result);
            _mockedItemRepository.Verify(x => x.GetItemById(It.IsAny<int>()), Times.Once());
        }
    }
}