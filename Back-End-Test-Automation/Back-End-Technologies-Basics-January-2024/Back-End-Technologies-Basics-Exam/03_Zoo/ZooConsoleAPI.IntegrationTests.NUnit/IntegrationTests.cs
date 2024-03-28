using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using ZooConsoleAPI.Business;
using ZooConsoleAPI.Business.Contracts;
using ZooConsoleAPI.Data.Model;
using ZooConsoleAPI.DataAccess;

namespace ZooConsoleAPI.IntegrationTests.NUnit
{
    public class IntegrationTests
    {
        private TestAnimalDbContext dbContext;
        private IAnimalsManager animalsManager;

        [SetUp]
        public void SetUp()
        {
            this.dbContext = new TestAnimalDbContext();
            this.animalsManager = new AnimalsManager(new AnimalRepository(this.dbContext));
        }


        [TearDown]
        public void TearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }


        //positive test
        [Test]
        public async Task AddAnimalAsync_ShouldAddNewAnimal()
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };

            // Act
            await this.animalsManager.AddAsync(newAnimal);

            // Assert
            var result = await this.dbContext.Animals.FirstOrDefaultAsync(x => x.CatalogNumber == newAnimal.CatalogNumber);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.CatalogNumber, Is.EqualTo(newAnimal.CatalogNumber));

        }

        //Negative test
        [Test]
        public async Task AddAnimalAsync_TryToAddAnimalWithInvalidCredentials_ShouldThrowException()
        {

            // Arrange
            var invalidAnimal = new Animal
            {
                CatalogNumber = "12321321312321",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };

            // Act and Assert
            var result = Assert.ThrowsAsync<ValidationException>(() => this.animalsManager.AddAsync(invalidAnimal));
            Assert.That(result.Message, Is.EqualTo("Invalid animal!"));
        }

        [Test]
        public async Task DeleteAnimalAsync_WithValidCatalogNumber_ShouldRemoveAnimalFromDb()
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            await this.animalsManager.AddAsync(newAnimal);
            await this.animalsManager.DeleteAsync(newAnimal.CatalogNumber);

            // Act
            var animalInDb = await this.dbContext.Animals.CountAsync();
            Assert.That(animalInDb, Is.EqualTo(0));
        }

        [TestCase(" ")]
        [TestCase(null)]
        public async Task DeleteAnimalAsync_TryToDeleteWithNullOrWhiteSpaceCatalogNumber_ShouldThrowException(string invalidCatalogNumber)
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            await this.animalsManager.AddAsync(newAnimal);

            // Act and Assert
            var result = Assert.ThrowsAsync<ArgumentException>(() => this.animalsManager.DeleteAsync(invalidCatalogNumber));
            Assert.That(result.Message, Is.EqualTo("Catalog number cannot be empty."));


        }

        [Test]
        public async Task GetAllAsync_WhenAnimalsExist_ShouldReturnAllAnimals()
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            var secondNewAnimal = new Animal
            {
                CatalogNumber = "88HERAAAA1D7",
                Name = "Hera",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            await this.animalsManager.AddAsync(newAnimal);
            await this.animalsManager.AddAsync(secondNewAnimal);

            // Act
            var result = await this.animalsManager.GetAllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetAllAsync_WhenNoAnimalsExist_ShouldThrowKeyNotFoundException()
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => this.animalsManager.GetAllAsync());
            Assert.That(exception.Message, Is.EqualTo("No animal found."));

        }

        [Test]
        public async Task SearchByTypeAsync_WithExistingType_ShouldReturnMatchingAnimals()
        {
           // Arrange
           var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            var secondNewAnimal = new Animal
            {
                CatalogNumber = "88HERAAAA1D7",
                Name = "Hera",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            await this.animalsManager.AddAsync(newAnimal);
            await this.animalsManager.AddAsync(secondNewAnimal);

            // Act
            var result = await this.animalsManager.SearchByTypeAsync(newAnimal.Type);

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));

            //var animalInDb = await this.dbContext.Animals.FirstOrDefaultAsync(x => x.Type == newAnimal.Type);
            //Assert.That(animalInDb, Is.Not.Null);
            //Assert.That(animalInDb.Type, Is.EqualTo(newAnimal.Type));

        }

        [TestCase(" ")]
        [TestCase(null)]
        public async Task SearchByTypeAsync_WithNonExistingType_ShouldThrowKeyNotFoundException(string invalidType)
        {
            
            // Act and Assert
            var result = Assert.ThrowsAsync<KeyNotFoundException>(() => this.animalsManager.SearchByTypeAsync(invalidType));
            Assert.That(result.Message, Is.EqualTo("Animal type cannot be empty."));

        }

        [Test]
        public async Task GetSpecificAsync_WithValidCatalogNumber_ShouldReturnAnimal()
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };

            await this.animalsManager.AddAsync(newAnimal);

            // Act
            var result = await this.animalsManager.GetSpecificAsync(newAnimal.CatalogNumber);

            // Assert
            Assert.NotNull(result);
        }

        [TestCase(" ")]
        [TestCase(null)]
        public async Task GetSpecificAsync_WithInvalidCatalogNumber_ShouldThrowKeyNotFoundException(string invalidCatalogNumber)
        {
            
            // Act and Assert
            var result = Assert.ThrowsAsync<KeyNotFoundException>(() => this.animalsManager.GetSpecificAsync(invalidCatalogNumber));
            Assert.That(result.Message, Is.EqualTo("Catalog number cannot be empty."));
        }

        [Test]
        public async Task UpdateAsync_WithValidAnimal_ShouldUpdateAnimal()
        {
            // Arrange
            var newAnimal = new Animal
            {
                CatalogNumber = "99DAISYYY1D7",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };
            
            await this.animalsManager.AddAsync(newAnimal);

            // Act
            newAnimal.Name = "UPDATED";
            await this.animalsManager.UpdateAsync(newAnimal);

            // Assert
            var animalInDb = await this.animalsManager.GetSpecificAsync(newAnimal.CatalogNumber);
            Assert.That(animalInDb.Name, Is.EqualTo(newAnimal.Name));
            Assert.That(animalInDb.Breed, Is.EqualTo(newAnimal.Breed));
            Assert.That(animalInDb.Type, Is.EqualTo(newAnimal.Type));
            Assert.That(animalInDb.Gender, Is.EqualTo(newAnimal.Gender));
        }

        [Test]
        public async Task UpdateAsync_WithInvalidAnimal_ShouldThrowValidationException()
        {
            // Arrange
            var invalidAnimal = new Animal
            {
                CatalogNumber = "",
                Name = "Daisy",
                Breed = "Golden Retriever",
                Type = "Dog",
                Gender = "Female",
                IsHealthy = true,
            };

            // Act and Assert
            var exception = Assert.ThrowsAsync<ValidationException>(() => this.animalsManager.UpdateAsync(invalidAnimal));
            Assert.That(exception.Message, Is.EqualTo("Invalid animal!"));
        }
    }
}

