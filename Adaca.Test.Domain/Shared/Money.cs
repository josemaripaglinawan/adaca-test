using Adaca.Test.Domain.Shared;

namespace Adaca.Test.Application.Domain.Shared
{
    public record Money(decimal Value, Currency Currency = Currency.PHP)
    {
        public sealed override string ToString()
        {
            return $"{Currency} {Value}";
        }
    }
}