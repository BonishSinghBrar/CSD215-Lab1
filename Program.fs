type Coach = {
    Name: string
    FormerPlayers: bool}
type stats = {
    win: int
    lose: int}
type team = {
    Name: string
    Coach: Coach
    stats: stats}
let team = [
   {Name="Chicago Bulls", Coach = {Name="Billy Donovan"; formerplayer=true};Stats={ Wins= 2344;Losses= 2254 }}
   {Name="Milwaukee Bucks", Coach = {Name="Adrian Griffin"; formerplayer=false};Stats={ Wins= 2340;Losses= 2103 }}
   {Name="Chicago Bulls", Coach = {Name="Billy Donovan"; formerplayer=true};Stats={ Wins= 2344;Losses= 2254}}
   {Name="Chicago Bulls", Coach = {Name="Billy Donovan"; formerplayer=true};Stats={ Wins= 2344;Losses= 2254}}
   {Name="Chicago Bulls", Coach = {Name="Billy Donovan"; formerplayer=true};Stats={ Wins= 2344;Losses= 2254}}]