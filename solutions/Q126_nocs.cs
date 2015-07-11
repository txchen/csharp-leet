// no cs yet, this is javascript

/**
 * @param {string} start
 * @param {string} end
 * @param {set} dict
 * @return {string[][]}
 */
var findLadders = function(start, end, dict) {
    var allLevels = {}
    allLevels[-1] = new Set()
    allLevels[0] = new Set([start])
    var currentStarts = [ start ]
    var currentLevel = 1
    while (true) {
        var found = false
        allLevels[currentLevel] = new Set()
        var nextStarts = []
        for (var i = 0; i < currentStarts.length; i++) {
            var s = currentStarts[i]
            for (var j = 0; j < s.length; j++) {
                for (var k = 0; k < 26; k++) {
                    var ns = s.substr(0, j) + letters[k] + s.substr(j + 1)
                    if (dict.has(ns) && s !== ns && !allLevels[currentLevel - 1].has(ns) && !allLevels[currentLevel - 2].has(ns)) {
                        if (nextStarts.indexOf(ns) == -1) {
                            nextStarts.push(ns)
                        }
                        allLevels[currentLevel].add(ns)
                        if (ns === end) {
                            found = true
                        }
                    }
                }
            }
        }
        if (found || nextStarts.length === 0) {
            break
        }
        currentLevel += 1
        currentStarts = nextStarts
    }
    if (!found) {
        return []
    }
    var result = [[end]]
    currentLevel -= 1
    while (currentLevel >= 0) {
        var tempResult = []
        for (var pi in result) {
            var path = result[pi]
            var sp = path[0]
            for (var j = 0; j < s.length; j++) {
                for (var k = 0; k < 26; k++) {
                    var tempS = sp.substr(0, j) + letters[k] + sp.substr(j + 1)
                    if (allLevels[currentLevel].has(tempS)) {
                        tempResult.push([tempS].concat(path))
                    }
                }
            }
        }
        currentLevel -= 1
        result = tempResult
    }
    return result
};

var letters = "abcdefghijklmnopqrstuvwxyz"
