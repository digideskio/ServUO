using Server;
using System;

namespace Server.Items
{
    public class GargishEpauletteBearingTheCrestOfBlackthorn4 : Cloak
    {
        public override bool IsArtifact { get { return true; } }
        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

        public override int LabelNumber { get { return 1123326; } } // Gargish Epaulette

        [Constructable]
        public GargishEpauletteBearingTheCrestOfBlackthorn4()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            ItemID = 0x9986;
            Attributes.BonusStr = 2;
            Attributes.BonusDex = 2;
            Attributes.BonusInt = 2;
            Hue = 2107;
        }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public GargishEpauletteBearingTheCrestOfBlackthorn4(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}