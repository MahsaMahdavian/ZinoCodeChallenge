using Xunit;
using ZinoCodeChallenge.Adapter;
using static ZinoCodeChallenge.Adapted.Length;
using static ZinoCodeChallenge.Adapted.Mass;

namespace ZinoCodeChallenge.Test
{
    public class Length_Converting_Test
    {
        [Fact]
        public void Should_Return_Value_After_Convert_Mass_MmToTon()
        {
            //Arrange
            var firstAmount = new Adapter<mg>(8);
            Convertor convertorMass = new MassConvertor();
            var mgToTon = "0.000000008";

            //Act
            var aimMass = convertorMass.ConvertUnit<mg, ton>(firstAmount);
            var convertToString=aimMass.CalculateUnit();
            //Assert
            Assert.NotNull(aimMass);
            Assert.Equal(convertToString, mgToTon);
        }
        [Fact]
        public void Should_Return_Value_After_Convert_length_CmToMm()
        {
            //Arrange
            var firstAmount = new Adapter<cm>(5);
            Convertor convertorLength = new LengthConvertor();
            var cmTomm = "50";

            //Act
            var aimlength = convertorLength.ConvertUnit<cm, mm>(firstAmount);
            var convertToString = aimlength.CalculateUnit();
            //Assert
            Assert.NotNull(aimlength);
            Assert.Equal(convertToString, cmTomm);           
        }
    }
}
