using NUnit.Framework;
using GarageGoopApp; // �������� �� ������������ ���� ������ �������

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
            // ���������, ��� ���� ������ (�� ������ �������� �������������� ��������)
            Assert.IsTrue(System.IO.File.Exists(filePath));

            // ������� ��������� ���� ����� �����
            System.IO.File.Delete(filePath);
        }
    }
}