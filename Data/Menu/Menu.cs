using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data.Menu
{
    public static class Menu
    {

        public static IEnumerable<IOrderItem> Entrees()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            List<IOrderItem> m_Enum = new List<IOrderItem>() { bb, dd, goo, pp, ss, tt, tb };

            return m_Enum;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> m_Enum = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries df = new DragonbornWaffleFries();
                FriedMiraak fm = new FriedMiraak();
                MadOtarGrits mod = new MadOtarGrits();
                VokunSalad vs = new VokunSalad();

                df.Size = size;
                fm.Size = size;
                mod.Size = size;
                vs.Size = size;

                m_Enum.Add(df);
                m_Enum.Add(fm);
                m_Enum.Add(mod);
                m_Enum.Add(vs);
            }

            return m_Enum;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> m_Enum = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();

                    ss.Size = size;
                    ss.Flavor = flavor;

                    m_Enum.Add(ss);
                }

                AretinoAppleJuice aj = new AretinoAppleJuice();
                CandlehearthCoffee cc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();

                aj.Size = size;
                cc.Size = size;
                mm.Size = size;
                ww.Size = size;

                m_Enum.Add(aj);
                m_Enum.Add(cc);
                m_Enum.Add(mm);
                m_Enum.Add(ww);

                CandlehearthCoffee ccd = new CandlehearthCoffee();
                ccd.Decaf = true;
                ccd.Size = size;
                m_Enum.Add(ccd);
            }

            return m_Enum;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> m_Enum = new List<IOrderItem>();
            m_Enum.AddRange(Sides());
            m_Enum.AddRange(Drinks());
            m_Enum.AddRange(Entrees());

            return m_Enum;
        }
    }
}
