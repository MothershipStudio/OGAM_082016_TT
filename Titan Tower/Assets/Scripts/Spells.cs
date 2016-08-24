using System.Collections;
using BaseClasses;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SpellsCollection
{
    public class Spells
    {
        public List<BaseSpell> Items;
        private BaseSpell fireball, firewave, imoloate, fireblast, firebolt, ringoffire, lavastrike, dragonBreath,
            wave, whirlwind, icyspikes, ringoffrost, frozenPillar, frostWave, storm, blizzard,
            mudStrike, rockThrow, vineWhip, razorLeaf, seedBombs, rockBlast, photosynthesis, earthQuake,
            spark, eletroCharge, lightning, discharge, thunderShock, thunderBolt, lightningStorm, thunder,
            goblinWave, wolfPack, siege, orcWave, trollWave, blackHorsemen, giant, dragon;

        public Spells()
        {
            Items = new List<BaseSpell>();

            goblinWave = new GoblinWave();
            Items.Add(goblinWave);

            wolfPack = new WolfPack();
            Items.Add(wolfPack);

            siege = new Siege();
            Items.Add(siege);

            orcWave = new OrcWave();
            Items.Add(orcWave);

            trollWave = new TrollWave();
            Items.Add(trollWave);

            blackHorsemen = new BlackHorsemen();
            Items.Add(blackHorsemen);

            giant = new Giant();
            Items.Add(giant);

            dragon = new Dragon();
            Items.Add(dragon);

            spark = new Spark();
            Items.Add(spark);

            eletroCharge = new EletroCharge();
            Items.Add(eletroCharge);

            lightning = new Lightning();
            Items.Add(lightning);

            discharge = new Discharge();
            Items.Add(discharge);

            thunderShock = new ThunderShock();
            Items.Add(thunderShock);

            thunderBolt = new ThunderBolt();
            Items.Add(thunderBolt);

            lightningStorm = new LightningStorm();
            Items.Add(lightningStorm);

            thunder = new Thunder();
            Items.Add(thunder);

            mudStrike = new MudStrike();
            Items.Add(mudStrike);

            rockThrow = new RockThrow();
            Items.Add(rockThrow);

            vineWhip = new VineWhip();
            Items.Add(vineWhip);

            razorLeaf = new RazorLeaf();
            Items.Add(razorLeaf);

            seedBombs = new SeedBombs();
            Items.Add(seedBombs);

            rockBlast = new RockBlast();
            Items.Add(rockBlast);

            photosynthesis = new Photosynthesis();
            Items.Add(photosynthesis);

            earthQuake = new Earthquake();
            Items.Add(earthQuake);
            
            wave = new Wave();
            Items.Add(wave);

            whirlwind = new Whirlwind();
            Items.Add(whirlwind);

            icyspikes = new IcySpikes();
            Items.Add(icyspikes);

            ringoffrost = new RingOfFrost();
            Items.Add(ringoffrost);

            frozenPillar = new FrozenPillar();
            Items.Add(frozenPillar);

            frostWave = new FrostWave();
            Items.Add(frostWave);

            storm = new Storm();
            Items.Add(storm);

            blizzard = new Blizzard();
            Items.Add(blizzard);

            fireball = new Fireball();
            Items.Add(fireball);

            firewave = new Firewave();
            Items.Add(firewave);

            imoloate = new Imoloate();
            Items.Add(imoloate);

            fireblast = new FireBlast();
            Items.Add(fireblast);

            ringoffire = new RingOfFire();
            Items.Add(ringoffire);

            lavastrike = new LavaStrike();
            Items.Add(lavastrike);

            dragonBreath = new DragonBreath();
            Items.Add(dragonBreath);
        }
        
        public BaseSpell UnlockSpell()
        {
            int total = 0;
            foreach(BaseSpell b in Items.Where(i => !i.Avaible))
            {
                total += b.Weight;
            }

            int pos = UnityEngine.Random.Range(1, total);

            total = 0;
            foreach (BaseSpell b in Items.Where(i => !i.Avaible))
            {
                total += b.Weight;
                if(total >= pos)
                {
                    b.Avaible = !b.Avaible;
                    return b;
                }
            }

            return null;
        }


        public List<BaseSpell> AviableSpells()
        {
            return Items.Where(p => p.Avaible).ToList();
        }

        public class Fireball : BaseSpell
        {
            public Fireball()
            {
                this.ManaCost = 1;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = true;
                this.Name = "Bola de fogo";
                this.Description = "Joga um bola de chamas incandecentes no inimido. Causa 25 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 25);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Firewave : BaseSpell
        {
            public Firewave()
            {
                this.ManaCost = 1;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Onda de fogo";
                this.Description = "Uma enorme onda de fogo avança sobre seus inimigos. Causa 25 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 25);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Imoloate : BaseSpell
        {
            public Imoloate()
            {
                this.ManaCost = 2;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Imolação";
                this.Description = "Envolve o alvo em chamas. Causa 30 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 30);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class FireBlast : BaseSpell
        {
            public FireBlast()
            {
                this.ManaCost = 4;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Explosão de chamas";
                this.Description = "Causa uma explosão de chamas no inimigo. Causa 50 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 50);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class FireBolt : BaseSpell
        {
            public FireBolt()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Dardo de chamas";
                this.Description = "Arrema um dardo chamas no inimigo. Causa 70 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 70);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class RingOfFire : BaseSpell
        {
            public RingOfFire()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Anel de chamas";
                this.Description = "Envolve o inimigo em um anel de chamas. Causa 75 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 75);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class LavaStrike : BaseSpell
        {
            public LavaStrike()
            {
                this.ManaCost = 8;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Ataque de lava";
                this.Description = "Transforma o chão próximo ao inimigo em um mar de lava. Causa 90 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 90);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class DragonBreath : BaseSpell
        {
            public DragonBreath()
            {
                this.ManaCost = 10;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Bafo de dragão";
                this.Description = "Gospe fogo vivo, da mesma forma que um poderoso dragão. Causa 100 pontos de dano de fogo.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 100);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Wave : BaseSpell
        {
            public Wave()
            {
                this.ManaCost = 2;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = true;
                this.Name = "Onda";
                this.Description = "Lança uma enorme onda d'água sobre o inimigo. Causa 20 pontos de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 20);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Whirlwind : BaseSpell
        {
            public Whirlwind()
            {
                this.ManaCost = 2;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Redemoinho";
                this.Description = "Conjura um redemoinho que engole o inimigo. Causa 30 pontos de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 30);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class IcySpikes : BaseSpell
        {
            public IcySpikes()
            {
                this.ManaCost = 3;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Espinhos de gelo";
                this.Description = "Arremesa espinhos de gelo sobre o inimigo. Causa 35 pontos de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 35);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class RingOfFrost : BaseSpell
        {
            public RingOfFrost()
            {
                this.ManaCost = 4;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Anel de gelo";
                this.Description = "Envolve o inimigo em um anel de gelo. Causa 40 pontos de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 40);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class FrozenPillar : BaseSpell
        {
            public FrozenPillar()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Pilar de Gelo";
                this.Description = "Congela o inimigo parcialmente. Não causa dano, mas impede uma ação do inimigo no próximo turno.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
                enemy.nextRoundAction--;
            }
        }

        public class FrostWave : BaseSpell
        {
            public FrostWave()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Onda de gelo";
                this.Description = "Conjura uma parede de gelo que cai sobre o inimigo. Causa 55 de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 55);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Storm : BaseSpell
        {
            public Storm()
            {
                this.ManaCost = 6;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Tempestade";
                this.Description = "Uma tempestada cai sobre o inimigo. Causa 70 de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 70);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Blizzard : BaseSpell
        {
            public Blizzard()
            {
                this.ManaCost = 6;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Nevasca";
                this.Description = "Uma nevasca arrasa tudo ao redor do inimigo. Causa 90 de dano de água.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 90);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class MudStrike : BaseSpell
        {
            public MudStrike()
            {
                this.ManaCost = 2;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = true;
                this.Name = "Arremesar lama";
                this.Description = "Arremesa uma grande quantidade de lama no inimigo. Causa 20 de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 20);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class RockThrow : BaseSpell
        {
            public RockThrow()
            {
                this.ManaCost = 2;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Arremesar pedra";
                this.Description = "Arremesa uma grande pedra no inimigo. Causa 25 de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 25);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class VineWhip : BaseSpell
        {
            public VineWhip()
            {
                this.ManaCost = 4;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Chicote de vinhas";
                this.Description = "Prende o inimigo. Não causa dano, mas o inimigo perde uma ação na próxima rodada.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
                enemy.nextRoundAction--;
            }
        }

        public class RazorLeaf : BaseSpell
        {
            public RazorLeaf()
            {
                this.ManaCost = 4;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Folhas-navalha";
                this.Description = "Arremesa folhas afiadas como navalhas. Causa 40 de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 40);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class SeedBombs : BaseSpell
        {
            public SeedBombs()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Sementes-bombas";
                this.Description = "Conjura sementes que explodem em poucos segundos. Causa 45 de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 45);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class RockBlast : BaseSpell
        {
            public RockBlast()
            {
                this.ManaCost = 8;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Rochas explosivas";
                this.Description = "Transforma pedras em poderosas bombas. Causa 65 de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 60);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Photosynthesis : BaseSpell
        {
            public Photosynthesis()
            {
                this.ManaCost = 0;
                this.Weight = 1;
                this.Avaible = false;
                this.Name = "Fotosintese";
                this.Description = "Utilizando a força do sol, o mago recebe 5 pontos extras de mana.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
                player.energy += 5;
            }
        }

        public class Earthquake : BaseSpell
        {
            public Earthquake()
            {
                this.ManaCost = 10;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Fotosintese";
                this.Description = "Causa um poderoso terremoto que arrasa tudo em uma grande distância. Causa 100 pontos de dano de natureza.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 100);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Spark : BaseSpell
        {
            public Spark()
            {
                this.ManaCost = 1;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = true;
                this.Name = "Fagulha";
                this.Description = "Joga uma pequena fagulha elétrica no inimigo. Causa 15 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 15);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class EletroCharge : BaseSpell
        {
            public EletroCharge()
            {
                this.ManaCost = 1;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Carga elétrica";
                this.Description = "Faz com o corpo do inimigo transforme-se em uma pequena bateria. Causa 25 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 25);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Lightning : BaseSpell
        {
            public Lightning()
            {
                this.ManaCost = 3;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Raio";
                this.Description = "Arremesa a forma menor de um raio no inimigo. Causa 35 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 35);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Discharge : BaseSpell
        {
            public Discharge()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Descarga elétrica";
                this.Description = "Arremesa a forma intermediária de um raio no inimigo. Causa 45 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 45);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class ThunderShock : BaseSpell
        {
            public ThunderShock()
            {
                this.ManaCost = 6;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Choque do trovão";
                this.Description = "Arremesa a forma melhorada de Descarga Elétrica de um raio no inimigo. Causa 60 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 60);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class ThunderBolt : BaseSpell
        {
            public ThunderBolt()
            {
                this.ManaCost = 6;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Flecha de trovão";
                this.Description = "Cria uma flecha mágica composta por pura energia elétrica. Causa 70 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 70);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class LightningStorm : BaseSpell
        {
            public LightningStorm()
            {
                this.ManaCost = 8;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Tempestade des trovões";
                this.Description = "Conjura uma tempestade que disparas inumeros feitiços de Raio. Causa 85 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 85);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Thunder : BaseSpell
        {
            public Thunder()
            {
                this.ManaCost = 8;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Trovão";
                this.Description = "Conjura o mais poderoso de todos os trovões e arremessa no inimigo. Causa 90 pontos de dano elétrico.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 0);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 90);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class GoblinWave : BaseSpell
        {
            public GoblinWave()
            {
                this.ManaCost = 3;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = true;
                this.Name = "Horda de goblins";
                this.Description = "Invoca um horda de goblins. Causa 30 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 30);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class WolfPack : BaseSpell
        {
            public WolfPack()
            {
                this.ManaCost = 4;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Matilha de lobos";
                this.Description = "Invoca uma matilha de lobos. Causa 40 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 40);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Siege : BaseSpell
        {
            public Siege()
            {
                this.ManaCost = 5;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Cerco";
                this.Description = "Invoca um exercito humano. Causa 50 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 50);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class OrcWave : BaseSpell
        {
            public OrcWave()
            {
                this.ManaCost = 6;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Horda orc";
                this.Description = "Invoca uma horda orc. Causa 60 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 60);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class TrollWave : BaseSpell
        {
            public TrollWave()
            {
                this.ManaCost = 7;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Horda troll";
                this.Description = "Invoca uma horda troll. Causa 70 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 70);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class BlackHorsemen : BaseSpell
        {
            public BlackHorsemen()
            {
                this.ManaCost = 8;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Cavaleiro das trevas";
                this.Description = "Invoca um exercito de cavaleiros negros. Causa 80 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 80);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Giant : BaseSpell
        {
            public Giant()
            {
                this.ManaCost = 9;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Gigante";
                this.Description = "Invoca um gigante. Causa 90 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 90);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }

        public class Dragon : BaseSpell
        {
            public Dragon()
            {
                this.ManaCost = 10;
                this.Weight = 11 - this.ManaCost;
                this.Avaible = false;
                this.Name = "Dragão";
                this.Description = "Invoca um dragão. Causa 100 pontos de dano de trevas.";

                Dictionary<Element, int> damage = new Dictionary<Element, int>();
                damage.Add(Element.Black, 100);
                damage.Add(Element.Blue, 0);
                damage.Add(Element.Green, 0);
                damage.Add(Element.Yellow, 0);
                damage.Add(Element.Red, 0);
            }

            public override void ApplyEffect(BasePlayer enemy, BasePlayer player)
            {
            }
        }
    }


}