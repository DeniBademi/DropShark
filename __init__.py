from sqlalchemy.sql import func
from datetime import datetime
from flask_sqlalchemy import SQLAlchemy
from flask.app import Flask

    
app = Flask(__name__)
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///dropshark.db'
app.config['MAX_CONTENT_LENGTH'] = 16 * 1024 * 1024
db = SQLAlchemy(app)
