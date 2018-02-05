using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteApp.DTO
{
    public class WeaponsList
    {
        public List<AssualtRifleDTO> AssualtRifles { get; set; } = new List<AssualtRifleDTO>();
        public List<SubmachineDTO> Submachines { get; set; } = new List<SubmachineDTO>();
        public List<ShotgunDTO> Shotguns { get; set; } = new List<ShotgunDTO>();
        public List<SniperDTO> Snipers { get; set; } = new List<SniperDTO>();
        public List<PistolDTO> Pistols { get; set; } = new List<PistolDTO>();
        public List<ExplosiveDTO> Explosives { get; set; } = new List<ExplosiveDTO>();
    }
}
