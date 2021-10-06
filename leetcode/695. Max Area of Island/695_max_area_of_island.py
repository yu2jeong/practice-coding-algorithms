class Solution:
    def bfs(self, visited:List[List[int]], cur_m, cur_n, grid:List[List[int]]):       
        queue = deque()
        queue.append((cur_m,cur_n))
        dirs = [(-1,0), (0,-1), (1,0), (0,1)] #top, left, bottom ,right
        area = 1
        while queue:
            state = queue.popleft()
            
            for dir in dirs:
                next_m, next_n = state[0] + dir[0], state[1] + dir[1]

                if(0 <= next_m < len(grid) and 0 <= next_n < len(grid[0])) and grid[next_m][next_n] == 1 and visited[next_m][next_n] == 0:
                    visited[next_m][next_n] = 1
                    queue.append((next_m, next_n))
                    area += 1
                    
        return area
                    
    def maxAreaOfIsland(self, grid: List[List[int]]) -> int:
        m = len(grid)
        n = len(grid[0])
        result = 0
        visited = [[0 for _ in range(n)] for _ in range(m)]
        dirs = [(-1,0), (0,-1), (1,0), (0,1)] #up #left # bottom #right

        for i in range(m):
            for j in range(n):
                if grid[i][j] == 1 and not visited[i][j]:
                    visited[i][j] = 1
                    result = max(result,self.bfs(visited, i,j, grid))
        return result
                
