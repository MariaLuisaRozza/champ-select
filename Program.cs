Console.WriteLine("  _                                    ____   __   _                               _     \r\n | |                                  / __ \\ / _| | |                             | |    \r\n | |     ___  __ _  __ _ _   _  ___  | |  | | |_  | |     ___  __ _  ___ _ __   __| |___ \r\n | |    / _ \\/ _` |/ _` | | | |/ _ \\ | |  | |  _| | |    / _ \\/ _` |/ _ \\ '_ \\ / _` / __|\r\n | |____  __/ (_| | (_| | |_| |  __/ | |__| | |   | |____  __/ (_| |  __/ | | | (_| \\__ \\\r\n |______\\___|\\__,_|\\__, |\\__,_|\\___|  \\____/|_|   |______\\___|\\__, |\\___|_| |_|\\__,_|___/\r\n                    __/ |                                      __/ |                     \r\n                   |___/                                      |___/                      \nQual é o seu estilo de campeão favorito dentre as opções: atirador / suporte / lutador / assassino / tanque / mago ?");
string estilo = Console.ReadLine()!.ToLower();

Console.WriteLine("Qual rota você pretende jogar ? (toplane / jungle / midlane / botlane)");
string rota = Console.ReadLine()!.ToLower(); 

if (estilo.Equals("atirador"))
{
    switch (rota)
    {
        case "toplane": Console.WriteLine("Campeões atiradores para utilizar na toplane são: \n1. Quinn\n2. Teemo\n3. Urgot ");
            break;
        case "jungle": Console.WriteLine("Campeões atiradores para utilizar na jungle são:\n1. Graves\n2. Kindred ");
            break;
        case "midlane": Console.WriteLine("Campeões atiradores para utilizar na midlane são:\n1. Azir\n2. Corki\n3. Ezreal\n4. Varus\n5. Teemo  ");
            break;
        case "botlane": Console.WriteLine("Campeões atiradores são ideais para utilizar na botlane! Alguns deles são:\n1. Ashe\n2. Caitlyn\n3. Jhin\n4. Jinx\n5. Kai'Sa\n6. Kalista\n7. Kog'Maw\n8. Lucian\n9. Miss Fortune\n10. Sivir\n11. Tristana\n12. Twitch\n13. Varus\n14. Vayne\n15. Xayah\n16. Samira");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else if (estilo.Equals("suporte"))
{
    switch (rota)
    {
        case "toplane":
            Console.WriteLine("Campeões suportes para utilizar na toplane são:\n1. Tahm Kench\n2. Galio\n3. Anivia ");
            break;
        case "jungle":
            Console.WriteLine("Campeões suportes não são muito adequados para utilizar na jungle. Porém o único utilizável é :\n1. Pyke  ");
            break;
        case "midlane":
            Console.WriteLine("Campeões suportes para utilizar na midlane são:\n1. Seraphine\n2. Zyra\n3. Lux\n4. Karma\n5. Morgana\n6. Anivia  ");
            break;
        case "botlane":
            Console.WriteLine("Campeões suportes são ideais para utilizar na botlane! Alguns deles são:\n1. Lulu\n2. Pyke\n3. Braum\n4. Leona\n5. Janna\n6. Sona\n7. Soraka\n8. Lux\n9. Taric\n10. Morgana\n11. Thresh\n12. Nami");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else if (estilo.Equals("lutador"))
{
    switch (rota)
    {
        case "toplane":
            Console.WriteLine("Campeões lutadores para utilizar na toplane são:\n1. Tryndamere\n2. Sion\n3. Riven\n4. Aatrox\n5. Camille\n6. Darius\n7. Fiora\n8. Garen\n9. Jax\n10. Irélia\n11. Nasus ");
            break;
        case "jungle":
            Console.WriteLine("Campeões lutadores para utilizar na jungle são:\n1. Gragas\n2. Xin zhao\n3. Warwick\n4. Udyr\n5. Poppy\n6. Olaf\n7. Jungle\n8. Jarvan IV\n9. Lee Sin\n10. Hecarim\n11. Ekko");
            break;
        case "midlane":
            Console.WriteLine("Campeões lutadores para utilizar na midlane são:\n1. Yone\n2. Sylas\n3. Yasuo\n4. Irelia\n5. Vladimir\n6. Gragas\n7. Malphite ");
            break;
        case "botlane":
            Console.WriteLine("Campeões lutadores para utilizar na botlane são:\n1. Nilah\n2. Blitzcranck");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else if (estilo.Equals("assassino"))
{
    switch (rota)
    {
        case "toplane":
            Console.WriteLine("Campeões assassinos para utilizar na toplane são:\n1. Akali\n2. Pantheon\n3. Teemo\n4. Yone ");
            break;
        case "jungle":
            Console.WriteLine("Campeões assassinos para utilizar na jungle são:\n1. Shaco\n2. Master Yi\n3. Nidalee\n4. Evelynn\n5. Nocturne\n6. Talon\n7. Rengar\n8. Kha'Zix\n9. Zed\n10. Naafiri\n11. Viego ");
            break;
        case "midlane":
            Console.WriteLine("Campeões assassinos para utilizar na midlane são:\n1. Qiyana\n2. Zed\n3. Fizz\n4. Talon\n5. LeBlanc\n6. Katarina\n7. Kassadin\n8. Akali");
            break;
        case "botlane":
            Console.WriteLine("Campeões assassinos para utilizar na botlane são:\n1. Pyke\n2. Vayne");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else if (estilo.Equals("tanque"))
{
    switch (rota)
    {
        case "toplane":
            Console.WriteLine("Campeões tanques para utilizar na toplane são:\n1. Ornn\n2. Illaoi\n3. Volibear\n4. Maokai\n5. Cho'Gath\n6. Singed\n7. Tahm Kench\n8. Darius ");
            break;
        case "jungle":
            Console.WriteLine("Campeões tanques para utilizar na jungle são:\n1. Zac\n2. Sejuani\n3. Volibear\n4. Nunu & Willump\n5. Poppy\n6. Rammus\n7. Amumu ");
            break;
        case "midlane":
            Console.WriteLine("Campeões tanques para utilizar na midlane são:\n1. Galio\n2. Malphite");
            break;
        case "botlane":
            Console.WriteLine("Campeões tanques para utilizar na botlane são:\n1. Rell\n2. Braum\n3. Nautilus\n4. Leona\n5. Alistar\n6. Taric\n7. Blitzcranck\n8. Amumu");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else if (estilo.Equals("mago"))
{
    switch (rota)
    {
        case "toplane":
            Console.WriteLine("Campeões magos para utilizar na toplane são:\n1. Anivia\n2. Vladimir\n3. Ryze\n4. Kennen\n5. Gwen ");
            break;
        case "jungle":
            Console.WriteLine("Campeões magos para utilizar na jungle são:\n1. Gragas\n2. Karthus\n3. Fiddlesticks\n4. Sylas\n5. Elise");
            break;
        case "midlane":
            Console.WriteLine("Campeões magos para utilizar na midlane são:\n1. Vex\n2. Zoe\n3. Neeko\n4. Aurelion Sol\n5. Lissandra\n6. Syndra\n7. Ziggs\n8. Ahri\n9. Viktor\n10. Rumble\n11. Cassiopeia");
            break;
        case "botlane":
            Console.WriteLine("Campeões magos para utilizar na botlane são:\n1. Ezreal\n2. Zilean\n3. Veigar\n4. Morgana\n5. Swain\n6. Lux\n7. Karma\n8. Brand\n9. Seraphine\n10. Vel'Koz");
            break;
        default:
            Console.WriteLine("Digite uma rota válida.");
            break;
    }
}
else
{
    Console.WriteLine("Digite um estilo válido!");
}
