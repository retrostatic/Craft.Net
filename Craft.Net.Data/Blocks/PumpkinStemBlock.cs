using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Craft.Net.Data.Items;

namespace Craft.Net.Data.Blocks
{
    public class PumpkinStemBlock : Block
    {
        public override short Id
        {
            get { return 104; }
        }

        public override BoundingBox? BoundingBox
        {
            get { return null; }
        }

        public override bool RequiresSupport
        {
            get { return true; }
        }

        public override Vector3 SupportDirection
        {
            get { return Vector3.Down; }
        }

        public override bool GetDrop(ToolItem tool, out ItemStack[] drop)
        {
            drop = new[] { new ItemStack(new PumpkinSeedsItem(), 1) };
            return true;
        }
    }
}
