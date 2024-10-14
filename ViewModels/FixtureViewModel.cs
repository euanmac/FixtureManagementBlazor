   using FixtureManagementBlazor.Models;
    
   namespace FixtureManagementBlazor.ViewModels;

    public struct FixtureViewModel {
        public Guid Id {get;set;}
        public String Team {get;set;} = "";
        public Guid TeamId {get;set;}
        public String Opponent {get; set;} = "";
        public DateOnly Date {get; set;}
        public bool IsHome {get; set;}
        public String Pitch {get; set;} = "";
        public String Start {get; set;} = "";
        public String End {get; set;} = "";
        public string Type {get; set;} = "";
        public bool IsAllocated = false;

        public FixtureViewModel(Fixture fixture) {
            this.Id = fixture.Id;
            this.Team = fixture.Team!.DisplayName;
            this.TeamId = fixture.TeamId;
            this.Opponent = fixture.Opponent;
            this.IsHome = fixture.IsHome;
            this.Type = fixture.FixtureType.FixtureTypeShortName();
            this.Date = fixture.Date;
            if (fixture.IsAllocated) 
            {
                this.IsAllocated = true;
                this.Pitch = fixture.FixtureAllocation!.Pitch!.Name;
                this.Start = fixture.FixtureAllocation!.Start.ToString("hh:mm");
                this.End = (fixture.FixtureAllocation!.Start + fixture.FixtureAllocation!.Duration).ToString("hh:mm");
            }
        }
        

    }