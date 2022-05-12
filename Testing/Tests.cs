using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace Testing
{
    public class Tests
    {
        private ExamDBContext _dbContext;
        private GenreContext _genreContext;

        [SetUp]
        public void Setup()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            _dbContext = new ExamDBContext();
            _genreContext = new GenreContext(_dbContext);
        }

        [Test]
        public void CreateGenre_ShouldReturnOK()
        {
            
            _genreContext.Create(new Genre("Action"));
            var game = _genreContext.Read(1);

            Assert.NotNull(game);
        }

        [Test]
        public void ReadGenre_ShouldReturnOK()
        {
            _genreContext.Create(new Genre("Action"));
            var game = _genreContext.Read(1);

            Assert.NotNull(game);
        }

        [Test]
        public void ReadAllGenres_ShouldReturnOK()
        {
            _genreContext.Create(new Genre("Action"));

            var game = _genreContext.ReadAll();

            Assert.NotNull(game);
        }

        [Test]
        public void UpdateGenre_ShouldReturnOK()
        {
            _genreContext.Create(new Genre("Action"));
            var game = _genreContext.Read(1);
            game.Name = "Horizon";
            _genreContext.Update(game);
            game = _genreContext.Read(1);
            Assert.AreEqual(game.Name, "Horizon");
        }

        [Test]
        public void DeleteGenre_ShouldReturnOK()
        {
            _genreContext.Create(new Genre("Action"));
            _genreContext.Delete(1);
            var game = _genreContext.Read(1);
            Assert.IsNull(game);
        }
    }
}
