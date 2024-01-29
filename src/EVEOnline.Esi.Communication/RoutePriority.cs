namespace EVEOnline.Esi.Communication
{
    public class RoutePriority
    {
        public EndpointVersion Version { get; set; }
        public int Order { get; set; }
        public bool Enable { get; set; } = true;

        public static bool operator < (RoutePriority left, RoutePriority right) 
        {
            if (left.Enable && !right.Enable) return true;
            if (!left.Enable && right.Enable) return false;
            if (left.Enable && right.Enable && left.Order > right.Order) return false;
            if (left.Enable && right.Enable && left.Order < right.Order) return true;
            if (left.Enable && right.Enable && left.Order == right.Order) return false;

            return false;
        }

        public static bool operator > (RoutePriority left, RoutePriority right)
        {
            if (left.Enable && !right.Enable) return false;
            if (!left.Enable && right.Enable) return true;
            if (left.Enable && right.Enable && left.Order > right.Order) return true;
            if (left.Enable && right.Enable && left.Order < right.Order) return false;
            if (left.Enable && right.Enable && left.Order == right.Order) return false;

            return false;
        }

        public static bool operator == (RoutePriority left, RoutePriority right) 
        {
            if (!left.Enable && !right.Enable) return true;
            if (left.Enable && right.Enable && left.Order == right.Order) return true;

            return false;
        }

        public static bool operator != (RoutePriority left, RoutePriority right)
        {
            if (!left.Enable && right.Enable) return true;
            if (left.Enable && !right.Enable) return true;
            if (left.Enable && right.Enable && left.Order != right.Order) return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            return this == obj as RoutePriority;
        }
    }
}
