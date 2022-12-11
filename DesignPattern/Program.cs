using DesignPattern;
using System.Text.RegularExpressions;
using static System.Console;
class program
{
    public static void Main(string[] args)
    {
    }

    public int LengthOfLastWord(string s)
    {
        int idx = s.Length - 1;
        int cnt = 0;
        for (int i = idx; i >= 0; i--)
        {
            if (s[i] != ' ')
                cnt++;
            if (s[i] == ' ' && cnt > 0)
                break;     
        }
        return cnt;
    }
    public static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 != nums.Length)
            {
                if (nums[i] == nums[i + 1]) // 1 2 3 4 
                    return true;
            }
        }
        return false;
    }
    public static int LengthOfLastWord1(string s)
    {
        //s.Trim();
        int idx = s.Length - 1;
        int cnt = 0;
        for(int i = idx; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                cnt++;
            }
            else if (s[i] == ' ' && cnt >0)
            {
                break;
            }
        }
        return cnt;
    }
    public static int[] PlusOne(int[] digits)
    {
        int n = digits.Length - 1;
        List<int> result = new List<int>();
        int sum = 0;
        for (int i = n; i >= 0; i--)
        {
            sum += (digits[i] * (1+(i*1)));
        }
        sum += 1;
        int idx = result.Count - 1;
        if (idx == 0 && result[idx] == 9)
        {
            result.Add(1);
            result.Add(0);
        }
        else
        {
            while (sum > 0)
            {
                result.Add(sum % 10);
                sum /= 10;
            }
            result.Reverse();
        }
        return result.ToArray();
        
    }
    public int[] BuildArray(int[] nums)
    {
        int sz = nums.Length;
        int[] ans = new int[sz];
        for(int i = 0; i < sz; i++)
        {
            ans[i] = nums[nums[i]];
        }
        return ans;
    }
    public int FinalValueAfterOperations(string[] operations)
    {
        int ans = 0;
        foreach(var item in operations)
        {
            ans = item == "++X" || item == "X++" ? ans += 1 : ans -= 1;
        }
        return ans;
    }
    public int[] Shuffle(int[] nums, int n)
    {
        List<int> ans = new List<int>();
        int j = n;
        for (int i = 0; i < n * 2 && j < n*2; i++)
        {
            if ((i != n * 2) && (j != n * 2))
            {
                ans.Add(nums[i]);
                ans.Add(nums[j]);
                j++;
            }
        }
        return ans.ToArray();   
    }
    public int NumIdenticalPairs(int[] nums)
    {
        int cnt = 0;
        for(int i = 0;i<nums.Length;i++)
        {
            for(int j = i+1;j < nums.Length;j++)
            {
                if (nums[i] == nums[j]) cnt++;
            }
        }
        return cnt;
    }
    public bool IsSubsequence(string s, string t)
    {
        if(s.Length > t.Length) return false;
        int ptr1 = 0;
        int ptr2 = 0;
        int cnt = 0;
        while(ptr1 < s.Length && ptr2 < t.Length)
        {
            if (s[ptr1] == t[ptr2])
            {
                ptr1++;
                ptr2++;
                cnt++;
            }
            else ptr2++;
        }
        return cnt == s.Length;
        

    }

    public int RemoveElement(int[] nums, int val)
    {
        List<int> ans = new List<int>();
        for(int i = 0;i<nums.Length;i++)
        {
            if (nums[i] != val)
            {
                ans.Add(nums[i]);
            }
        }
        return ans.Count;
        
    }
    public void MoveZeroes(int[] nums)
    {
        int idx = 0;
        int ptr = nums.Length - 1;
        while(idx < nums.Length && ptr >= 0)
        {
            if(nums[idx] == 0 && nums[ptr] != 0 && idx < ptr)
            {
                int temp = nums[idx];
                nums[idx] = nums[ptr];
                nums[ptr] = temp;
                idx++;
                ptr--;
            }
            else
            {
                idx++;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);
        }
    }
    public int Search(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        Array.Sort(nums);
        while(start <= end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else return mid;
        }
        return -1;
    }
    public int MostWordsFound(string[] sentences)
    {
        int ans = 0;
        int res = 0;
        foreach (var item in sentences)
        {
            string[] result = item.Split(' ');
            res = Math.Max(ans, result.Length);
        }
        return res;
    }
    public int MaximumWealth(int[][] accounts)
    {
        /*
          1 2 3
          3 2 1
         */
        int sum = 0;
        int ans = 0;
        int res = 0;
        for(int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts.Length; j++)
            {
                sum += accounts[i][j];
            }
            res = Math.Max(sum, ans);
        }
        return res;
    }
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> ans = new List<bool>();
        int mx = candies[0];
        foreach (var item in candies)
        {
            if(item > mx)
            {
                mx = item;
            }
        }
        foreach (var item in candies)
        {
            if (item + extraCandies < mx)
            {
                ans.Add(false);
            }
            else ans.Add(true);
        }
        return ans;
    }
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int cnt = 0;
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    cnt++;
                }
            }
            res[i] = cnt;
        }
        return res;
    }
    public int[] SortedSquares(int[] nums)
    {
        var res = nums.Select(n => n * n).ToArray();
        Array.Sort(res);
        return res;
    }
    public int ArrangeCoins(int n)
    {
        int i = n-1;
        int ans = 1;
        int j = 1;
        int cnt = 0;
        while(n > 0)
        {
            ans = n - i; //5-4  5 - 3 5-2 
            n -= j;
            if(ans == j)
            {
                cnt++;
            }
            i--;
            j++;
        }
        return cnt;
    }
    public string RestoreString(string s, int[] indices)
    {
        char[] ans = new char[indices.Length];
        string res = "";
        for (int i = 0; i < indices.Length; i++)
        {
            ans[indices[i]] = s[i];
        }
        foreach(char c in ans)
        {
            res += c;
        }
        return res;
    }
    public int HammingWeight(uint n)
    {
        int ans = 0;
        while(n != 0)
        {
            uint rem = n % 2;
            if (rem == 1) ans++;
            n /= 2;
        }
        return ans;
    }
    public bool isDigit(char c)
    {
        return c>='0' && c<='9';
    }
    public bool IsPalindrome(string s)
    {

        string res = "";
        string lower = s.ToLower();
        foreach(var c in lower)
        {
            if( (c >= 'a' && c <= 'z') || isDigit(c))
                res += c;
        }
        int i = 0, j = res.Length;
        while(i < j)
        {
            if (res[i++] != res[j--]) return false;
        }
        return true;
    }
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int i = -1;
        if (ruleKey == "type") i = 0;
        if (ruleKey == "color") i = 1;
        if (ruleKey == "name") i = 2;

        int ans = 0;
        for (int j = 0; j < items.Count; j++)
        {
            if (items[j][i] == ruleValue) ans++;
        }

        return ans;
    }

    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string ans1 = "";
        string ans2 = "";
        foreach (string item in word1)
        {
            ans1 += item;
        }
        foreach (string item in word2)
        {
            ans2 += item;
        }
        return ans1 == ans2;
    }
    public string[] SortPeople(string[] names, int[] heights)
    {
        SortedDictionary<int, string> ans = new SortedDictionary<int, string>();
        int idx1 = 0,idx2 = 0;
        while(idx1 < names.Length)
        {
            ans.Add(heights[idx1++], names[idx2++]);
        }
        var res = ans.OrderByDescending(x => x.Key);
        List<string> list = new List<string>();
        foreach (var item in res)
        {
            list.Add(item.Value);
        }
        return list.ToArray();
    }

    public int CountConsistentStrings(string allowed, string[] words)
    {
        int ans = words.Length;
        foreach (string item in words)
        {
            foreach (char c in item)
            {
                if (!allowed.Contains(c)) ans--;
            }
        }
        return ans;
    }
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int[] freq =  { 0 };
        List<int> ans = new List<int>();
        for (int i = 1; i <= nums.Length; i++)
        {
            freq[i]++;
        }
        for (int i = 1; i <= freq.Length; i++)
        {
            if (freq[i] == 0)
            {
                ans.Add(freq[i]);
            }
        }
        return ans;

    }
    public string LongestCommonPrefix(string[] strs)
    {
        var res = strs.OrderBy(x => x.Length);
        string ans = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (string item in strs)
            {
                if (strs[0][i] == item[i])
                    ans+=strs[0][i];
            }
        }
        return ans;
    }
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char,char> MapST = new Dictionary<char,char>();
        Dictionary<char,char> MapTs = new Dictionary<char,char>();
        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i], c2 = t[i];
            if((MapST.ContainsKey(c1) && MapST[c1] != c2)
                || (MapTs.ContainsKey(c2) && MapTs[c2] != c1))
                return false;
            MapST[c1] = c2;
            MapTs[c2] = c1;
        }
        return true;
    }
    public void swap(char c,char s)
    {
        char temp = c;
        c = s;
        s = temp;
    }
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length / 2;
        int cnt = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 != nums.Length)
            {
                if (nums[i] == nums[i + 1])
                {
                    cnt++;
                    if (cnt > n)
                        return nums[i];
                }
            }
        }
        return nums[0];
   


    }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> ans = new Dictionary<int, int>();
        List<int> res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(ans.ContainsKey(target - nums[i]))
            {
                res.Add(i);
                res.Add(ans[target - nums[i]]);
                return res.ToArray();
            }
            ans.TryAdd(nums[i], i);
        }
        return res.ToArray();
    }
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> ans = new Dictionary<string, IList<string>>();
        List<IList<string>> res = new List<IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string x = strs[i];
            Array.Sort(x.ToCharArray());
            ans[x].Add(strs[i]);
        }
        foreach(var item in ans)
        {
            res.Add(item.Value);
        }
        return res;
    }
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> ans = new HashSet<string>(); 
        foreach (var item in emails)
        {
            string str = "";
            string[] res = item.Split("@");
            for(int i = 0; i < res[0].Length; i++)
            {
                char c = res[0][i];
                if (c == '+') break;
                else if (c == '.') continue;
                str += c;
            }
            str += "@"+res[1];
            ans.Add(str);
        }
        return ans.Count;
    }
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        List<int> ans = new List<int>();
        ans.Add(0);
        foreach (var item in flowerbed)
        {
            ans.Add(item);
        }

        ans.Add(0);
        for (int i = 0; i < ans.Count; i++)
        {
            if(i - 1 != -1 && i + 1 != ans.Count)
            {
                if (ans[i] == 0 && ans[i + 1] == 0 && ans[i - 1] == 0)
                {
                    n--;
                    i++;
                }
            }
        }
        return n <= 0;
    }
    public int MajorityElement1(int[] nums)
    {
        int sz = nums.Length / 2;
        Dictionary<int, int> ans = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if(ans.ContainsKey(item))
            {
                ans[item]++;
            }
            ans.TryAdd(item, 1);
            if (ans[item] >= sz) return item;
        }
        return nums[0];
    }
    public int PivotIndex(int[] nums)
    {
        int total = 0;
        foreach (var item in nums)
        {
            total += item;
        }
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            total -= nums[i];
            if (total == leftSum) return i;
            leftSum += nums[i];
        }
        return -1;
    }
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            IList<int> item = new List<int>();
            for (int j = 1; j < i; j++)
            {
                if (i != -1)
                {
                    item[j] = ans[i - 1][j - 1] + ans[i - 1][j];
                }
                ans.Add(item);
            }

        }
        return ans;
    }
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1;j<nums.Length;j++)
            {
                if (nums[i] == nums[j] && Math.Abs(i-j) <= k)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] ans = new int[nums.Length];
        int sum = 1;
        var allZeros = nums.Where(n => n == 0).ToArray();
        if (allZeros.Length == nums.Length || allZeros.Length == nums.Length - 1 || 
            (nums[nums.Length - 1] == 0 || nums[nums.Length - 2] == 0) &&
            (nums.Length > 2))
        {
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = 0;
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) continue;
                sum *= nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Contains(0))
                {
                    if (nums[i] == 0) ans[i] = sum;
                    else ans[i] = 0;
                }
                else
                {
                    ans[i] = sum / nums[i];
                }
            }
        }
        return ans;

    }
    int maxNumberOfBalloons(string text)
    {
        var dic = new Dictionary<char, int>()
            {
                {'b', 1 },
                {'a', 1 },
                {'l' , 2},
                {'o', 2 },
                {'n', 1 }
            };

            var dic2 = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (dic2.ContainsKey(ch))
                    dic2[ch]++;
                else dic2.Add(ch, 1);
            }

            int count = int.MaxValue;
            foreach (var keyVal in dic)
            {
                if (!dic2.ContainsKey(keyVal.Key))
                    return 0;

                count = Math.Min(count, dic2[keyVal.Key] / keyVal.Value);
            }

            return count;
        
    }
    public IList<int> FindDisappearedNumbers1(int[] nums)
    {
        List<int> ans = new List<int>();
        Dictionary<int,int> dic = new Dictionary<int,int>();
        foreach (var num in nums)
        {
            if(!dic.ContainsKey(num))
            {
                dic[num] = 1;
            }    
        }
        for (int i = 1; i <= nums.Length; i++)
        {
            if(!dic.ContainsKey(i))
            {
                ans.Add(i);
            }
        }
        return ans;
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        if (root1 == null || root2 == null) return false;
        if(root1.left == null && root1.right == null && root2.left == null && root2.right == null)
        {
            if (root1.val != root2.val) return false;
        }

        if(root1.left != null && root2.left != null)
            LeafSimilar(root1.left, root2.left);
        if (root1.right != null && root2.right != null)
            LeafSimilar(root1.right, root2.right);

        return true;
    }
    public int GCD(List<int> nums)
    {
        int mn = int.MaxValue;
        int mx = int.MinValue;
        foreach (var item in nums)
        {
            if(item > mx) mx = item;
            if (item < mn) mn = item;
        }
        int ans = 1;
        for (int i = 1; i <= mn; i++)
        {
            if (mn % i == 0 && mx % i == 0)
                ans = i;
        }
        return ans;
    }
   
    public bool HasGroupsSizeX(int[] deck)
    {
        Dictionary<int, int> ans = new Dictionary<int, int>();
        foreach(var item in deck)
        {
            if(ans.ContainsKey(item))
            {
                ans[item]++;
            }
            else
            {
                ans.Add(item, 1);
            }
        }
        var res = ans.OrderByDescending(x => x.Value).ToArray();
        for (int i = 0; i < res.Length; i++)
        {
            if (i + 1 != res.Length)
            {
                if (res[i].Value % res[i + 1].Value != 0) return false;
            }
        }
        return true;
    }
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);
        IList<int> res = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                res.Add(i);
        }
        return res;
    }
    public int CountNegatives(int[][] grid)
    {
        int count = 0;
        foreach (var item in grid)
        {
            foreach (var item2 in item)
            {
                if(item2 < 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }
    public string MakeGood(string s)
    {
        //LeeEetCode
        if (s.Length < 2) return s;
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (stack.Count > 0 && CapitalAndSmall(stack.Peek(), c))
            {
                stack.Pop();
            }
            else stack.Push(c);
        }
        string str = "";
        while(stack.Count > 0)
        {
            str+=stack.Pop();
        }

        string res = "";
        for (int i = str.Length-1; i >=0; i--)
        {
            res += str[i];
        }
        return res;
        
    }
    public bool CapitalAndSmall(char c1,char c2)
    {
        return Math.Abs(c1 - c2) == 32;
    }
    
    public string Interpret(string command)
    {
        string ans = "";
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
                ans += "G";

            if(i+1 != command.Length || i+2 != command.Length || i+3!=command.Length)
            {
                if (command[i] == '(' && command[i+1] == ')')
                {
                    ans += "o";
                }
                else if(command[i] == '(' && command[i+1] == 'a' && command[i+2] == 'l' && command[i+3] == ')')
                {
                    ans += "al";
                }

            }
        }
        return ans;
    }
    public static bool CheckIfPangram(string sentence)
    {
        string all = "abcdefghijklmnopqrstuvwxyz";
        HashSet<char> ans = new HashSet<char>();
        foreach (char c in sentence)
        {
            ans.Add(c);
        }
        Array.Sort(sentence.ToArray());
        return ans.Count == all.Length;
    }
    public bool AreOccurrencesEqual(string s)
    {
        Dictionary<char, int> ans = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if(ans.ContainsKey(c))
            {
                ans[c]++;
            }
            else
            {
                ans.Add(c, 1);
            }
        }
        List<int> res = new List<int>();
        foreach (var item in ans.Values)
        {
            res.Add(item);
        }
        for(int i = 0;i<res.Count;i++)
        {
            if (i + 1 != res.Count - 1)
            {
                if (res[i] != res[i + 1])
                    return false;
            }
        }
        return true;
    }
    public string ReverseWords(string s)
    {
        string ans = "";
        string[] res = ans.Split(" ");
        for(int i = 0;i<res.Length;i++)
        {
            string word = res[i];
            for(int j = word.Length - 1;j>=0;j--)
            {
                ans+=word[j];
            }
            if (i != res.Length)
            {
                ans += " ";
            }
        }
        return ans.TrimEnd();
    }
    public bool HalvesAreAlike(string s)
    {
        int i = 0;
        int j = s.Length / 2;
        int cntFirstPart = 0;
        int cntSecondPart = 0;
        while(i < j && j < s.Length)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
            {
                cntFirstPart++;
            }
            if (s[j] == 'a' || s[j] == 'e' || s[j] == 'i' || s[j] == 'o' || s[j] == 'u'
                || s[j] == 'A' || s[j] == 'E' || s[j] == 'I' || s[j] == 'O' || s[j] == 'U')
            {
                cntSecondPart++;
            }
            i++;
            j++;
        }
        return cntFirstPart == cntSecondPart;
    }
    public string ReversePrefix(string word, char ch)
    {
        string ans = "";
        if (!word.Contains(ch)) return word;
        else
        {
            int idx = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if(ch == word[i])
                {
                    idx = i;
                }
            }
            for(int i = idx;i>=0;i--)
            {
                ans+=word[i];
            }
            for (int i = idx + 1; i < word.Length; i++)
            {
                ans += word[i];
            }
        }
        return ans;
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> mix = new List<int>();
        foreach (var item in nums1)
        {
            mix.Add(item);
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            mix.Add(nums2[i]);
        }
        int[] ans = mix.ToArray();
        Array.Sort(ans);
        int half = ans.Length / 2;
        if (mix.Count == 0)
        {
            
            int mid = half + half - 1;
            return (double)mix[mid];
        }
        return (double)mix[half];

    }
    public int MostWordsFound1(string[] sentences)
    {
        int mx = 0;
        foreach (var item in sentences)
        {
            string[] res = item.Split(' ');
            if(res.Count() > mx)
            {
                mx = res.Length;
            }
        }
        return mx;
    }
    public string MergeAlternately(string word1, string word2)
    {
        int idx1 = 0;
        int idx2 = 0;
        string ans = "";
        while(idx1 < word1.Length && idx2 <word2.Length)
        {
            ans += word1[idx1++] + word2[idx2++];
        }
        if (idx1 < word1.Length) ans += word1.Substring(idx1);
        if (idx2 < word2.Length) ans += word2.Substring(idx2);
        return ans;
    }
    public int CountConsistentStrings1(string allowed, string[] words)
    {
        HashSet<char> ans = new HashSet<char>();
        foreach (char c in allowed)
        {
            ans.Add(c);
        }
        int count = 0;
        foreach (var item in words)
        {
            int cnt = 0;
            for(int i = 0;i<item.Length;i++)
            {
                if (!ans.Contains(item[i]))
                {
                    cnt = 1;
                    break;
                }
            }
            if(cnt == 0)
            {
                count++;
            }
        }

        return count;
    }
    public string TruncateSentence(string s, int k)
    {
        string[] split = s.Split(' ');
        string ans = "";
        for(int i = 0;i<k;i++)
        {
            ans += split[i] + " ";
        }
        return ans.TrimEnd();

    }
    public int Reverse(int x)
    {
        long res = 0;
        int ans = x;
        if(x != 0)
        {
            int r = x % 10;
            res = res * 10 + r;
            if (res > Int32.MaxValue || res < Int32.MinValue)
                return 0;
            x /= 10;
        }
        if (ans >= 0) return (int)res;
        else return (int) (-1 * res);
        
    }
    public int MyAtoi(string s)
    {
        string ans = "";
        bool negitive = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (i != 0)
            {
                if (s[i - 1] == '-' && (s[i] >= '0' || s[i] <= '9'))
                {
                    ans += s[i];
                    negitive = true;
                }
            }
            else if(s[i] >= '0' || s[i] <= '9')
            {
                ans += s[i];
            }
        }
        int res = 0;
        res = Int32.Parse(ans);
        if (negitive)
        {
            
            res *= -1;
            if (res < Int32.MinValue) return 0;
            else return res;
        }
        else
        {
            if (res > Int32.MaxValue) return 0;
            else return res;
        }
    }
    public int MaxProduct(int[] nums)
    {
        int largest = nums.OrderByDescending(n => n).Take(1).First();
        int secondLargest = nums.OrderByDescending(n => n).Skip(1).First();
        return largest - 1 * secondLargest - 1;

    }
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> ans = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if(ans.ContainsKey(i))
            {
                ans[i]++;
            }
            else
            {
                ans.Add(i, 1);
            }
        }
        var res = ans.OrderByDescending(x => x.Value).Take(k);
        int[] finalRes = new int[k];
        int idx = 0;
        foreach (var item in res)
        {
            finalRes[idx++] = item.Key;
        }
        return finalRes;
    }

}
public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
  }

