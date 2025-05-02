import webbrowser

def web_search(query):
    """
    Opens the default web browser and searches for the given query.
    """
    base_url = "https://www.google.com/search?q="
    search_url = base_url + query.replace(" ", "+")
    webbrowser.open(search_url)

if __name__ == "__main__":
    search_query = input("Enter your search query: ")
    web_search(search_query)