using WowPacketParser.Messages.Cli;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientMoveUpdateApplyMovementForce
    {
        public CliMovementStatus Status;
        public CliMovementForce Force;
    }
}