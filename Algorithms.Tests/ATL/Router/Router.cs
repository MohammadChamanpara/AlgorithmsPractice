namespace Algorithms.Tests.ATL.Router
{
    internal class Router
    {
        private readonly Dictionary<string, string> _routes = new Dictionary<string, string>();

        internal void WithRoute(string path, string result)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (result == null)
                throw new ArgumentNullException(nameof(result));

            if (_routes.ContainsKey(path))
                _routes[path] = result;
            else
                _routes.Add(path, result);
        }

        internal string Route(string path)
        {
            var result =
                ExactMatch(path) ??
                RegexMatch(_routes, path);

            if (result == null)
                throw new Exception($"Path {path} is not registered within the router.");

            return result;
        }

        private string? ExactMatch(string path)
        {
            if (_routes.ContainsKey(path))
                return _routes[path];

            return null;
        }

        private static string? RegexMatch(Dictionary<string, string> routes, string path)
        {
            foreach (var route in routes)
                if (IsMatch(route.Key, path))
                    return route.Value;

            return null;
        }

        private static bool IsMatch(string regex, string path)
        {
            int regexIndex = 0;
            int pathIndex = 0;

            // a/*/b
            // a/xyz/b
            while (regexIndex < regex.Length && pathIndex < path.Length)
            {
                // NOT A MATCH: a b
                if (!CharactersMatch(regex[regexIndex], path[pathIndex]))
                    return false;

                // EXACT MATCH: a a
                if (!AtAStar(regex, regexIndex))
                {
                    regexIndex++;
                    pathIndex++;
                    continue;
                }

                // MATCH NORMAL CHARACTER WITH A STAR * a
                if (!AtASlash(path, pathIndex))
                {
                    pathIndex++;
                    continue;
                }

                // MATCH SLASH WITH STAR * /
                regexIndex++;
            }

            if (regexIndex == regex.Length && pathIndex == path.Length)
                return true;

            return false;

        }

        private static bool AtASlash(string path, int pathIndex)
        {
            return path[pathIndex] == '/';
        }

        private static bool AtAStar(string regex, int regextIndex)
        {
            return regex[regextIndex] == '*';
        }

        private static bool CharactersMatch(char regexCharacter, char pathCharacter)
        {
            return regexCharacter == '*' || regexCharacter == pathCharacter;
        }
    }
}