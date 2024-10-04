   using FixtureManagementBlazor.Models;
    
   namespace FixtureManagementBlazor.ViewModels;

    public struct FixtureView {
        Guid FixtureID {get;set;}
        String Team {get;set;}
        Guid TeamId {get;set;}
        String Opponent {get; set;} = "";
        DateOnly Date {get; set;}
        bool IsHome {get; set;}
        String Pitch {get; set;} = "";
        TimeOnly Start {get; set;}

        private FixtureView(Fixture fixture) {
            this.FixtureID = fixture.Id;
            this.Team = fixture.Team!.Name;
            this.Opponent = fixture.Opponent;
            if (fixture.IsAllocated) 
            {
                this.Pitch = fixture.FixtureAllocation!.Pitch!.Name;
                this.Start = TimeOnly.FromDateTime(fixture.FixtureAllocation.Start);
            }
        }
        
    }