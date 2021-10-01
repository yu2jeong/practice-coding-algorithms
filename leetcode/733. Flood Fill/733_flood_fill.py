class Solution:
    def floodFill(self, image: List[List[int]], sr: int, sc: int, newColor: int) -> List[List[int]]:
        row_count = len(image)
        col_count = len(image[0])
        
        color = image[sr][sc]
        visited = [[0 for _ in range(col_count)] for _ in range(row_count)]
        dirs = [(0,-1), (1,0), (0,1),(-1,0)]  #left bottom right top
        
        queue = deque()
        queue.append((sr,sc))
        
        while queue:
            cur_row, cur_col = queue.popleft()
            image[cur_row][cur_col] = newColor

            for r, c in dirs:
                next_row, next_col = cur_row + r, cur_col + c

                if 0 <= next_row < row_count and 0 <= next_col < col_count:
                    if visited[next_row][next_col]:
                        continue
                    if image[next_row][next_col] == color:
                        visited[next_row][next_col] = 1
                        queue.append((next_row, next_col))
        
        return image     
