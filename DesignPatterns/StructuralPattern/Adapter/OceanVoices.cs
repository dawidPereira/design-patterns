using System.Collections.Generic;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public static class OceanVoices
    {
        public static IDictionary<int, string> OceanVoice = new Dictionary<int, string>
        {
            { 0, "“There’s nothing more beautiful than the way the ocean refuses to stop kissing the shoreline, no matter how many times it’s sent away.”"},
            { 1, "“If you want to hear the distant voice of the ocean put your ear to the lips of a seashell.”"},
            { 2, "“She loves the serene brutality of the ocean, loves the electric power she felt with each breath of wet, briny air.”"},
            { 3, "“Those who live by the sea can hardly form a single thought of which the sea would not be part.”"},
            { 4, "“You will love the ocean. It makes you feel small, but not in a bad way. Small because you realize you’re part of something bigger.”"},
        };
    }
}