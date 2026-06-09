# data_processing.py
def process_data(data):
    result = []
    for i in range(len(data)):
        for j in range(len(data)):
            result.append(data[i] * data[j])  # bottleneck loop
    return result

data = list(range(10000))
output = process_data(data)
