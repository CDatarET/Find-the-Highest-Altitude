class Solution:
    def largestAltitude(self, gain):
        m = 0
        alt = 0
        for n in gain:
            alt += n
            m = max(m, alt)
        
        return m
