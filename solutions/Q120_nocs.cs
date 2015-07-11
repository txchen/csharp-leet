// no cs yet, this is javascript

/**
 * @param {number[][]} triangle
 * @return {number}
 */
var minimumTotal = function(triangle) {
    var answer = triangle[triangle.length - 1]
    for (var j = triangle.length - 2; j >= 0; j--) {
        for (var i = 0; i <= j; i++) {
            answer[i] = triangle[j][i] + Math.min(answer[i], answer[i + 1])
        }
    }
    return answer[0]
};
