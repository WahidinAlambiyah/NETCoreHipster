using NETCoreHipster.Crosscutting.Constants;

namespace NETCoreHipster.Crosscutting.Exceptions;

public class InternalServerErrorException : BaseException
{
    public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
    {
    }
}
