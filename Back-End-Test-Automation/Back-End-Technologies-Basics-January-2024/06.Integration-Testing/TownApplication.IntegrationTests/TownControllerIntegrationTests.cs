namespace TownApplication.IntegrationTests
{
    public class TownControllerIntegrationTests
    {
        private readonly TownController _controller;

        public TownControllerIntegrationTests()
        {
            _controller = new TownController();
            _controller.ResetDatabase();
        }

        [Fact]
        public void AddTown_ValidInput_ShouldAddTown()
        {

            //Arrange
            var town = "Sofia";
            var population = town.Length * 1000;

            //Act
            _controller.AddTown(town, population);

            //Assert
            var result = _controller.GetTownByName(town);
            Assert.NotNull(result);
            Assert.Equal(population, result.Population);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("AB")]
        public void AddTown_InvalidName_ShouldThrowArgumentException(string invalidName)
        {
            
            // Arrange
            var population = 100;

            // Act & Assert
            var action = () => _controller.AddTown(invalidName, population);
            var exception = Assert.Throws<ArgumentException>(action); 
            Assert.StrictEqual("Invalid town name.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void AddTown_InvalidPopulation_ShouldThrowArgumentException(int invalidPopulation)
        {
            
            // Arrange
            var town = "Sofia";

            // Act
            var action = () => _controller.AddTown(town, invalidPopulation);

            // Assert
            var exception = Assert.Throws<ArgumentException>(action);
            Assert.StrictEqual("Population must be a positive number.", exception.Message);
        }

        [Fact]
        public void AddTown_DuplicateTownName_DoesNotAddDuplicateTown()
        {
            // Arrange
            var town = "Sofia";
            var population = 100;

            // Act
            _controller.AddTown(town, population);
            _controller.AddTown(town, population);

            // Assert
            var result = _controller.ListTowns();
            Assert.Single(result);
            var item = result[0];
            Assert.Equal(item.Name, town);
            Assert.Equal(item.Population, population);

        }

        [Fact]
        public void UpdateTown_ShouldUpdatePopulation()
        {
            
            // Arrange
            var town = "Sofia";
            var initialPopulation = 100;
            var updatedPopulation = initialPopulation + 1;

            // Act
            _controller.AddTown(town, initialPopulation);

            var getTown = _controller.GetTownByName(town);
            _controller.UpdateTown(getTown.Id, updatedPopulation);

            // Assert
            var result = _controller.GetTownByName(getTown.Name);
            Assert.NotNull(result);
            Assert.Equal(updatedPopulation, result.Population);
        }

        [Fact]
        public void DeleteTown_ShouldDeleteTown()
        {
            // Arrange
            var town = "Sofia";
            var population = 100;

            // Act
            _controller.AddTown(town, population);

            var getTown = _controller.GetTownByName(town);
            _controller.DeleteTown(getTown.Id);

             // Assert
            var result = _controller.GetTownByName(getTown.Name);
            Assert.Null(result);
        }

        [Fact]
        public void ListTowns_ShouldReturnTowns()
        {
            
            // Arrange
            var towns = new List<string> { "Sofia", "Plovdiv", "Varna" };
            var population = 0;

            // Act
            foreach (var town in towns)
            {
                population = town.Length * 1000;
                _controller.AddTown(town, population);
            }

            // Assert
            var townsList = _controller.ListTowns();
            Assert.Equal(towns.Count, townsList.Count);

            foreach (var town in towns)
            {
                var townExist = townsList.Any(x => x.Name == town);
                Assert.True(townExist);
                
            }
        }
    }
}
