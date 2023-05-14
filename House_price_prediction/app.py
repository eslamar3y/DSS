# Import Libraries
from flask import Flask, request, render_template

import model  # load model.py

app = Flask(__name__)

# render html page


@app.route('/')
def home():
    return render_template('index.html')

# get user input and the predict the output and return to user


@app.route('/predict', methods=['POST'])
def predict():

    # take data from form and store in each feature
    input_features = [x for x in request.form.values()]
    bath = input_features[0]
    balcony = input_features[1]
    total_sqft_int = input_features[2]
    bhk = input_features[3]
    price_per_sqft = input_features[4]
    area_type = input_features[5]
    availability = input_features[6]
    location = input_features[7]

    # predict the price of house by calling model.py
    predicted_price = model.predict_house_price(
        bath, balcony, total_sqft_int, bhk, price_per_sqft, area_type, availability, location)
    # predicted_price_mod = round((predicted_price * 1000000) * 0.37)

    # render the html page and show the output

    return render_template('index.html', prediction_text='Predicted Price of House is {} '.format(predicted_price))


if __name__ == "__main__":
    app.run(host="0.0.0.0", port="5000")

# if __name__ == "__main__":
#    app.run()
