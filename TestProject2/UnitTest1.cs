using NUnit.Framework;
using GarageGoopApp; // Замените на пространство имен вашего проекта

namespace GarageGoopApp.Tests
{
    [TestFixture]
    public class MainFormTests
    {
        [Test]
        public void GenerateReportWord_Success()
        {
            // Arrange
            MainForm mainForm = new MainForm();
            string filePath = "test_report.docx";

            // Act
            mainForm.GenerateReportWord(filePath);

            // Assert
            // Проверяем, что файл создан (вы можете добавить дополнительные проверки)
            Assert.IsTrue(System.IO.File.Exists(filePath));

            // Удаляем созданный файл после теста
            System.IO.File.Delete(filePath);
        }
    }
}