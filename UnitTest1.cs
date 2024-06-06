using FluentAssertions;
using org.ldk.structs;

namespace ldk_offer_parser_reproducer;

public class UnitTest1 {
    [Fact]
    public void Test1() {
        // Arrange
        const string? offerStr = "lno1pgx9getnwss8vetrw3hhyuckyypwa3eyt44h6txtxquqh7lz5djge4afgfjn7k4rgrkuag0jsd5xvxg";

        // Act
        var offerRes = Offer.from_str(offerStr);
        var offer = ((Result_OfferBolt12ParseErrorZ.Result_OfferBolt12ParseErrorZ_OK)offerRes).res;

        // Assert
        offer.expects_quantity().Should().BeTrue();
    }
}