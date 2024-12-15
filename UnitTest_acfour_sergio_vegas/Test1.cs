using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Runtime.InteropServices;

namespace UnitTest_acfour_sergio_vegas
{
    [TestClass]
    public sealed class UnitTest_acfour_sergio_vegas
    {
        [TestMethod]

        //Arrange
        [DataRow(5,5)]
        public void GestioErrorCorrect(int userNumb, int expected)
        {
            //Act
            acfour_sergio_vegas.implementacioDiagrama.GestioError(userNumb);
            //Assert
            Assert.AreEqual(expected, userNumb);
        }   
    
        [TestMethod]

        //Arrange
        [DataRow("sds")]
        public void GestioErrorIncorrect(int userNumb)
        {
            //Act
            acfour_sergio_vegas.implementacioDiagrama.GestioError(userNumb);
            //Assert
            Assert.ThrowsException(FormatException); //No he trobat cap informació per poder fer aquest unittest.
        }
    }
}
